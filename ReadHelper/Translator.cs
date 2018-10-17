using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Xml;


namespace ReadHelper
{
    public class Translator
    {
        public static List<string> Directions = new List<string>();
        public static Dictionary<string, string> Languages = new Dictionary<string, string>();

        public delegate void TranslatedTextChange();
        public event TranslatedTextChange OnTranslateChange = () => {};
        private string _translatedText;
        public string TranslatedText
        {
            get { return _translatedText; }
            set { _translatedText = value; OnTranslateChange(); }
        }

        public Translator()
        {
            GetLanguages();
        }

        public string TranslateByYandex(string Text, string Lang_from = "en",string Lang_to = "ru")
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                string Url = "https://translate.yandex.net/api/v1.5/tr/translate?key=" +
                    GetKey() + "&text=" + Text + "&lang="+Lang_from+"-"+Lang_to;
                using (StreamReader XmlFile = new StreamReader(HttpWebRequest.Create(Url).GetResponse().GetResponseStream()))
                {
                    xmlDocument.Load(XmlFile);
                    foreach (XmlElement x in xmlDocument.DocumentElement)
                    {
                        TranslatedText = x.InnerText;
                    }
                }
            }
            catch (WebException exception)
            {
                //TODO обработать ошибки

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
            return TranslatedText;
        }

        public static string GetKey()
        {
            using (var stream = new StreamReader(@"C:\Users\Proobel\Documents\Visual Studio 2017\Projects\ReadHelper\ReadHelper\YandexTranslateAPIKEY.key"))
            {
                return stream.ReadLine();
            }
        }

        public static string[] GetLanguages(string Ui ="ru")
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                string Url = "https://translate.yandex.net/api/v1.5/tr/getLangs?key=" +
                    GetKey() + "&ui=" + Ui;
                using (StreamReader XmlFile = new StreamReader(HttpWebRequest.Create(Url).GetResponse().GetResponseStream()))
                {
                    xmlDocument.Load(XmlFile);

                    foreach(XmlElement Dir in xmlDocument.DocumentElement["dirs"])
                    {
                        Directions.Add(Dir.InnerText);
                    }
                    foreach (XmlElement Lang in xmlDocument.DocumentElement["langs"])
                    {
                        Languages.Add(Lang.GetAttribute("key"), Lang.GetAttribute("value"));
                    }
                }
            }
            catch (WebException exception)
            {
                //TODO обработать ошибки
                //Пример ошибки
                //Если выполнение запроса невозможно, возвращается сообщение об ошибке.

                //< Error code = "401" message = "API key is invalid" />
                //   Коды ответов
                //401
                //Неправильный API-ключ

                //402
                //API - ключ заблокирован
                string responseText;
                using (var reader = new StreamReader(exception.Response.GetResponseStream()))
                {
                    responseText = reader.ReadToEnd();
                }
            }
            return new string[] { "" };
        }

    }
}
