using Microsoft.AspNet.Identity;
using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T1908EOnlineCourse.Models;

namespace T1908EOnlineCourse.Controllers
{
    public class HomeController : Controller
    {
        Model2 _db = new Model2();
        public ActionResult Index()
        {
            var data = _db.Courses.ToList();

            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = " Con vit con Your contact page.";

            return View();
        }

        public ActionResult PaymentWithPaypal(int? courseId, string Cancel = null)
        {

            T1908EOnlineCourse.Models.Course course = _db.Courses.Find(courseId);

            var coursePrice = course.price;
            decimal DEBITAMT = Convert.ToDecimal(string.Format("{0:F2}", coursePrice));

            string convertString = DEBITAMT.ToString();
            //getting the apiContext  
            APIContext apiContext = PaypalConfiguration.GetAPIContext();
            try
            {
                //A resource representing a Payer that funds a payment Payment Method as paypal  
                //Payer Id will be returned when payment proceeds or click to pay  
                string payerId = Request.Params["PayerID"];
                if (string.IsNullOrEmpty(payerId))
                {
                    //this section will be executed first because PayerID doesn't exist  
                    //it is returned by the create function call of the payment class  
                    // Creating a payment  
                    //here we are generating guid for storing the paymentID received in session  
                    //which will be used in the payment execution  
                    var guid = Convert.ToString((new Random()).Next(100000));
                    //CreatePayment function gives us the payment approval url  
                    //on which payer is redirected for paypal account payment  
                    // baseURL is the url on which paypal sendsback the data.  
                    string baseURI = Request.Url.Scheme + "://" + Request.Url.Authority + "/Home/PaymentWithPayPal?courseId=" + courseId + "&";
                    var createdPayment = this.CreatePayment(apiContext, baseURI + "guid=" + guid, course.name, convertString);
                    //get links returned from paypal in response to Create function call  
                    var links = createdPayment.links.GetEnumerator();
                    string paypalRedirectUrl = null;
                    while (links.MoveNext())
                    {
                        Links lnk = links.Current;
                        if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                        {
                            //saving the payapalredirect URL to which user will be redirected for payment  
                            paypalRedirectUrl = lnk.href;
                        }
                    }
                    // saving the paymentID in the key guid  
                    Session.Add(guid, createdPayment.id);
                    var sessionPaymentId = Session[guid];

                    return Redirect(paypalRedirectUrl);
                }
                else
                {
                    // This function exectues after receving all parameters for the payment  
                    var guid = Request.Params["guid"];
                    var executedPayment = ExecutePayment(apiContext, payerId, Session[guid] as string);
                    //System.Diagnostics.Debug.WriteLine(ExecutePayment.state.ToLower());
                    //If executed payment failed then we will show payment failure message to user  
                    if (executedPayment.state.ToLower() != "approved")
                    {
                        return View("FailureView");
                    }
                }
            }
            catch (PayPal.PaymentsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            var userId = User.Identity.GetUserId();
            _db.UserCourses.Add(new UserCourse()
            {
                course_id = (int)courseId,
                user_id = userId,
                status = (int?)UserCourse.UserCourseStatus.ACTIVE,
                type = (int?)UserCourse.UserCourseType.BUYER
            });

            _db.Transactions.Add(new Models.Transaction()
            {
                course_id = (int)courseId,
                status = 1,
                price = DEBITAMT,
                user_id = userId,
                created_at = DateTime.Today,
                updated_at = DateTime.Today
            });
            var userID = _db.UserCourses.Where(c => c.course_id == courseId && c.type == (int?)UserCourse.UserCourseType.OWNER).Single();
            var user = _db.AspNetUsers.Find(userID.user_id);
            user.balance = user.balance + ((DEBITAMT * 90) / 100);
            _db.SaveChanges();

            //on successful payment, show success page to user.  
            return RedirectToAction("DetailCourse", "Course", new
            {
                id = courseId
            });
        }
        private PayPal.Api.Payment payment;
        private Payment ExecutePayment(APIContext apiContext, string payerId, string paymentId)
        {

            var paymentExecution = new PaymentExecution()
            {
                payer_id = payerId
            };
            this.payment = new Payment()
            {
                id = paymentId
            };
            return this.payment.Execute(apiContext, paymentExecution);
        }
        private Payment CreatePayment(APIContext apiContext, string redirectUrl, string name, string price)
        {
            //create itemlist and add item objects to it  
            var itemList = new ItemList()
            {
                items = new List<Item>()
            };
            //Adding Item Details like name, currency, price etc  
            itemList.items.Add(new Item()
            {
                name = name,
                currency = "USD",
                price = price,
                quantity = "1",
                sku = "sku"
            });
            var payer = new Payer()
            {
                payment_method = "paypal"
            };
            // Configure Redirect Urls here with RedirectUrls object  
            var redirUrls = new RedirectUrls()
            {
                cancel_url = redirectUrl + "&Cancel=true",
                return_url = redirectUrl
            };
            // Adding Tax, shipping and Subtotal details  
            var details = new Details()
            {
                tax = "0",
                shipping = "0",
                subtotal = price
            };
            //Final amount with details  
            var amount = new Amount()
            {
                currency = "USD",
                total = price, // Total must be equal to sum of tax, shipping and subtotal.  
                details = details
            };
            var transactionList = new List<PayPal.Api.Transaction>();
            // Adding description about the transaction  
            transactionList.Add(new PayPal.Api.Transaction()
            {
                description = "Transaction description",
                invoice_number = "your generated invoice number", //Generate an Invoice No  
                amount = amount,
                item_list = itemList
            });
            this.payment = new Payment()
            {
                intent = "sale",
                payer = payer,
                transactions = transactionList,
                redirect_urls = redirUrls
            };
            // Create a payment using a APIContext  
            return this.payment.Create(apiContext);
        }
    }
}