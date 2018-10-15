﻿using System;
using System.IO;
using System.Net;
using System.Xml;


namespace ReadHelper
{
    public class Translator
    {
        public delegate void TranslatedTextChange();
        public event TranslatedTextChange OnTranslateChange = () => {
            //return string.Empty; 
};
        private string _translatedText;

        public string TranslatedText
        {
            get { return _translatedText; }
            set { _translatedText = value; OnTranslateChange(); }
        }

        public string TranslateByYandex(string Text)
        {
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
                        TranslatedText = x.InnerText;
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
            return TranslatedText;
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
