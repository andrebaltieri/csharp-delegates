using System;
using System.Collections;
using System.Collections.Generic;
using DelegatesSample.Models;

namespace DelegatesSample
{
    class Program
    {
        private delegate void OnSuccessDelegate(IEnumerable<ArticleModel> data);

        private delegate void OnErrorDelegate(ErrorModel data);

        static void Main(string[] args)
        {
            OnSuccessDelegate onSuccessHandler = OnSuccess;
            OnErrorDelegate onErrorHandler = OnError;

            GetArticles(onSuccessHandler, onErrorHandler);

            Console.ReadKey();
        }

        private static void OnSuccess(IEnumerable<ArticleModel> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item.Title);
            }
        }

        private static void OnError(ErrorModel data)
        {
            Console.WriteLine($"ERRO: {data.Message}");
        }

        private static void GetArticles(OnSuccessDelegate onSuccess, OnErrorDelegate onError)
        {
            try
            {
                var data = new List<ArticleModel>();
                data.Add(new ArticleModel(1, "Orientação a objetos"));
                data.Add(new ArticleModel(2, "Fundamentos do C#"));
                throw new Exception("Deu ruim");
                onSuccess(data);
            }
            catch (Exception ex)
            {
                onError(new ErrorModel($"Ocorreu um erro: {ex.Message}"));
            }
        }
    }
}