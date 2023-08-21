using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:/Users/porto/Desktop/chrome driver/chromedriver-win64/chromedriver.exe");

            // This will open up the URL
            driver.Url = "https://www.invertexto.com/texto-criptografado";

            string textoEncrypt = "qVQ9WxPYpAlhpquFOksv2rOw2XCw98xMuIBYdX3wKi_wDAuEXdRKBumSUVozyKyCy8SdY6zAXAH3A3cNvNecw8Drkx3fsrhk2RPrmWCV5a7Skzgd-v3ztR-yySzZzRRINp-t9hy5zVrEMn5FSLP5sehDNOrO5VF8EBHZF9N6TzfXw9jbgCXYrDAKmh-cODyFJ3m-2LZJth5GFvT1--OsNASxhI2YfphtyJOYu214uluz8M5MtLoUflYxM4Z2R6JVG2CPHs7Lh16UTeQkefa-qNJ52-hObSBv5bvrsBbpnWKH2XpeFYxqJYbr3mBRbYKVao8NTri691NaN-pbOCEZGTBB8rqnGk52-vJSu10jhHIU-Ac0Bnip_l9V-hX7W4wezGbXuf7iLy5nBZTuol6ZDrJ-1UuioZ6cAC)nyE22EOYXuEVYcsRZCKOgyrX7QN-uHxM5VWqAzmL85qf2spMwRYG7v4ZXPDLr57MrWTZssrJybla6ZwQkHLFtyCIFXLdL1SvGpzizNzuYINy-ezQucMoA6jEqs0W1N2YC-qJzQCdpius2SpGn8zfZbL-yuF1124EYY8FY5P1Cm97Jz8BmLSPt3nOVIYZDTRVLzzjK1GIPJZOOLoCOOtYgAX4UuH89UGQw_fPT7efgOvDYZjhK8BgRgOcI1YVHTON2bhpKcZU51JHBZ825NL_74ikh-LOVf2InSQhiWADXGOAqqoDUM-PXcm9dKp6UUx_qVKiauH092RQTceR-aDJQwMrcga3s7PTmucgNj2KQhFCAELl-qs8xZ3vuRQkpF0Y77hCOT2SoKs5yRQTqUBprBAdZhZV3dcbdbnVXRAW18mdodwgTEqmGzsn7PVJytfPRLF18wwZj5ZYTPRouvKM1zBqQJYjiHznSKzeDiz2Thcilie0HyEpDV8JowmjGtcS-MGS4xE5oEorGttQkb2jZmtgozn7gmaAj9j6T_qkqRSULLfUF-7H3VXosR2Bgb9Z5NoBVyYctN1zaHuT2TLadUxwGf2gCLIOcadWHHcSflvRns5o5ZR5SkQ_cKE-TmTYSSzOSMsVIcc9zrSTp2jpj8kJucbwjNO0CwK6Dt7E-Oe_qywl8c5pHBu_7aBLYStzee-fvghZARhgUTCvelYgrV3Qx6-Lx66iGIFRRg7BNeTHPB8Ha1Qjvt1Bpiy517tU6YAF2E4yuEnXjZbvxXxAX-Dtmicy96nKDvQLs51FR202Jjp46GVG_XhRLAuRkPJUFE9U3-r6_phVM4CLJmapUtw3QDhDpPE_HZt1NuWPdAEKDQezRjXFw9cVIBLXhSs7YuD_1F6aLeJsgBM915_260XM4qOblgEAhGXBcqmGdjTJvG8XwH23IJK2_xydP6kyJWucWeBjvrxYuREXgZbraSJy8KR4LID_KpSUt902R8q2nyUukY716zY2FIXcJW60J9rkd2n3KOMRtSOseJTNWmOIAEZDIkTZjOhWY4rVnpgGp5JX5yKydvQshNyFZIdi-eCIBXwLIHO7eSUSOqqQDwbXxFj1W8PweMTxj8cMDeGT6f5ODCyIXRXzrIZSqUNyD810nZ7_J9CKUZLHZPs5y-TdLpH2m1pazLWaKcL_Aw4_5B-YoKUFpVj-rUXp5dos3SosihZ4TDL7k6n1A4FomBHQJbpCJ7mTjPkeujBRSzuurkNqRg5f60ThkHq-3keWL7s91qh7uez-__T6IRYXZzcigdzbQ303dROCw7rHtX1xs9JAhkQFCdvEH2Je3tIolwKw3nAvH33q2-OhFrMYC7Zwt-fc502QaaBpo2-wJRyHixPKJtUy0a3J44KNuHMh4f40AhI";

            var textbox = driver.FindElement(By.XPath("/html/body/main/div/div[1]/div/div[3]/form/textarea"));
    

            textbox.SendKeys(textoEncrypt);

            string[] anos = {"2020", "2021", "2022", "2023"};
            string[] meses = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"};
            List<string> days = new List<string>();


            for(int i = 1; i < 32; i++)
            {

                if(i < 10)
                {
                    days.Add($"0{i}");

                }
                else
                {
                    days.Add(i.ToString());
                }
            }


            foreach( var a in anos)
            {

                foreach (var m in meses)
                {
                    foreach(var d in days)
                    {
                        //Thread.Sleep(1000);
                        var decodificar = driver.FindElement(By.XPath("/html/body/main/div/div[1]/div/div[3]/form/div[2]/span/button"));
                        var chave = driver.FindElement(By.XPath("/html/body/main/div/div[1]/div/div[3]/form/div[2]/input"));
                        chave.SendKeys($"{d}/{m}/{a}");
                       // Thread.Sleep(1000);
                        decodificar.Click();
                        var result = driver.FindElement(By.XPath("/html/body/main/div/div[1]/div/div[1]/form/textarea"));

                        string text = result.Text;

                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            break;
                        }
                    }
                }
            }

        }
    }
}
