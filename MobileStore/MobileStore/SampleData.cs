using System;
using Microsoft.EntityFrameworkCore;
using MobileStore.Models;
using System.Linq;
namespace MobileStore
{
    public static class SampleData
    {
        public  static void Initialize(MobileContext context )
        {
            if(!context.Phones.Any())
            {
                context.Phones.AddRange(

                    new Phone
                    {
                        Name = "Iphone 6s",
                        Company = "Apple",
                        Price = 600
                    },
                    new Phone
                    {
                        Name = "Galaxy Fold",
                        Company = "Sumsung",
                        Price = 2000
                    },
                     new Phone
                     {
                         Name = "Lumia 950",
                         Company = "Microsoft",
                         Price = 500
                     });
                }
            context.SaveChanges();
        }
    }
}
