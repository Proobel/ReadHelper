using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadHelper
{
    public static class Translator
    {
        public static string TranslateByYandex(string Text)
        {
            string str = "";
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                string Url = "https://translate.yandex.net/api/v1.5/tr/translate?key=" +
                    GetKey() + "&text=" + Text + "&lang=en-ru";
                using (StreamReader XmlFile = new StreamReader(HttpWebRequest.Create(Url).GetResponse().GetResponseStream()))
                {
                    xmlDocument.Load(XmlFile);
                    foreach (XmlElement x in xmlDocument.DocumentElement)
                    {
                        str = x.InnerText;
                    }
                }
            }
            catch (WebException exception)
            {
//200
//Операция выполнена успешно

//401
//Неправильный API-ключ

//402
//API - ключ заблокирован

//404
//Превышено суточное ограничение на объем переведенного текста

//413
//Превышен максимально допустимый размер текста

//422
//Текст не может быть переведен

//501
//Заданное направление перевода не поддерживается
                string responseText;
                using (var reader = new StreamReader(exception.Response.GetResponseStream()))
                {
                    responseText = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {

            }
            return str;
        }

        private static string GetKey()
        {
            using (var stream = new StreamReader(@"C:\Users\Proobel\Documents\Visual Studio 2017\Projects\ReadHelper\ReadHelper\YandexTranslateAPIKEY.key"))
            {
                return stream.ReadLine();
            }
        }
    }
}
