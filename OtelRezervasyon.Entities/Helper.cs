using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OtelRezervasyon.Entities
{
    public static class Helper
    {
        public static bool Gonder(string konu, string icerik, string mailAdress)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("hasankamil2355@gmail.com");
            ePosta.To.Add(mailAdress);
            ePosta.Subject = konu;
            ePosta.Body = icerik;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("hasankamil2355@gmail.com", "123123haskam");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException)
            {
                kontrol = false;
            }
            return kontrol;
        }
        public static bool TelefonFormatKontrol(string Telefon)
        {
            string RegexDesen = @"^(05(\d{9}))$";
            Match Eslesme = Regex.Match(Telefon, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success; // bool değer döner
        }
        public static bool TcNoFormatKontrol(string TcNo)
        {
            string RegexDesen = @"^[1-9]{1}[0-9]{10}$";
            Match Eslesme = Regex.Match(TcNo, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success;
        }
        public static bool MailFormatKontrol(string Mail)
        {
            string RegexDesen = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Match Eslesme = Regex.Match(Mail, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success;
        }
        public static bool HarfKontrol(string Cumle)
        {
            string RegexDesen = @"^\p{L}+$"; //@"^[a-zA-Z]*$";
            Match Eslesme = Regex.Match(Cumle, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success;
        }
        public static bool SifreKontrol(string Cumle)
        {
            string RegexDesen = @"^([a-zA-Z0-9]{6,})$";
            Match Eslesme = Regex.Match(Cumle, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success;
        }
    }
}
