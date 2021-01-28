using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using homework1.DataAccess;
using homework1.Model;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace homework1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            using (var ctx = new ClassContext())
            {

                ctx.Database.EnsureCreated();
                Teacher t = new Teacher
                {
                    TeacherName = " Rota"

                };
                ctx.Teachers.Add(t);

                Class C = new Class
                {
                    ClassName = " Math"

                };
                ctx.Classes.Add(C);
                Student S = new Student
                {
                    StudentName = " Behnaz"

                };
                ctx.Studenets.Add(S);
                Corse Co = new Corse
                {
                    CorseName = " Math2"

                };
                ctx.Corses.Add(Co);
            }


                
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
