using Generics;
using Lambda_expression;
using LINQ;
using System;
using EventsAndDelegates;
using ExceptionHandling;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdvancedCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region implement delegate
            //var processor = new PhotoProcessor();
            //var filters = new PhotoFilters();

            //Action<Photo> filterHandler = filters.ApplyBrightness;
            //filterHandler += filters.ApplyContrast;
            //filterHandler += RemoveRedEyeFilter;

            //processor.Process("me.jpg", filterHandler);
            #endregion


            #region lambda expressions

            ////either use the method
            //Console.WriteLine(Lambda.Square(5));

            ////with lambda and delegate
            ////args => expression
            //Func<int, int> SquareTwo = number => number * number;
            #endregion

            #region events and delegates

            //var video = new Video() { Title = "Video 1" };
            //var videoEncoder = new VideoEncoder(); //publisher
            //var mailService = new MailService(); //subscriber
            //var messageService = new MessageService(); //subscriber

            //videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            //videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            //videoEncoder.Encode(video);
            #endregion

            #region extension methods
            //string post = "This is meant to be a long post blah blah blah. . . ";
            //var shortEndPost = post.Shorten(5);

            //Console.WriteLine(shortEndPost);
            #endregion

            #region using LINQ

            //var books = new BookRepository().GetBooks();

            //var cheapBooks = books.Where(x => x.Price < 8).Select(x => x.Title);
            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book);
            //}

            //var bookSelect = books.SingleOrDefault(b => b.Title == "price is 5").Title;
            //Console.WriteLine(bookSelect);

            //var threeBooks = books.Skip(2).Take(3);

            #endregion

            #region exception handling
            //try
            //{
            //    var calculator = new Calculator();
            //    calculator.Divide(5, 0);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("don't divide by zero");
            //}
            //catch(ArithmeticException ex)
            //{
            //    Console.WriteLine("something ain't right");
            //}
            //catch (Exception)
            //{

            //    throw;
            //}


            //StreamReader streamReader = null;

            //try
            //{
            //    streamReader = new StreamReader(@"C:\file.zip");
            //    var content = streamReader.ReadToEnd();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (streamReader != null)
            //        streamReader.Dispose();
            //}

            ////best way to dispose a object not handled by the CLR

            //try
            //{
            //    using(var streamRead = new StreamReader(@"C:\file.zip"))
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            #endregion
        }

        #region delegate mathod
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply remove red eye");
        }
        #endregion
    }
}
