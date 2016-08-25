using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using autoProject.dbClases;

namespace autoProject
{
    class DbDefoultInitializer :CreateDatabaseIfNotExists<OurBaseContext>
    {
        // add defoult value to table Users and Client with diferrent lavel accsrss
         protected override void Seed(OurBaseContext context)
         {

            IList<User> DefaultUser = new List<User>();

          DefaultUser.Add( new User { Id = 1, CodeAccsess = "1", Position = "Boss", Login = "boss", Password = "1111" });
          DefaultUser.Add( new User { Id = 2, CodeAccsess = "2", Position = "Manadger", Login = "manadger", Password = "2222" });
          DefaultUser.Add( new User { Id = 3, CodeAccsess = "2", Position = "Admin", Login = "admin", Password = "3333" });

             foreach (User stdUser in DefaultUser)
             {
                 context.Users.Add(stdUser);
             }


            IList<Client> DefaultClient = new List<Client>();

          DefaultClient.Add(new Client { Id = 1, fullName = "Литвак Виктор", address = "г.Винница, ул.Соборная 1", passportData = "AB 548147", notes = "имеет 3 авто" });
          DefaultClient.Add(new Client { Id = 2, fullName = "Роман Пивовар", address = "г.Винница, ул.Соборная 2", passportData = "AB 548148", notes = "распиздяй" });
          DefaultClient.Add(new Client { Id = 3, fullName = "Влад Чегаровский", address = "г.Винница, ул.Соборная 3", passportData = "AB 548149", notes = "део анус" });

             foreach (Client stdClient in DefaultClient)
             {
                 context.Clients.Add(stdClient);
             }

        




         base.Seed(context);
    }   
         

      

    }
                      

    
}
