using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using EntityMySQL.MySQL;

namespace EntityMySQL
{
    public partial class Form1 : Form
    {
        private ConnectDb connect;
        public Form1()
        {
            InitializeComponent();
            DbContextFactory newContextFactory = new DbContextFactory();
            connect = newContextFactory.CreateContext();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            connect.Users.Add(new User() {Name = "test1"});
            connect.SaveChanges();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            //connect.Users.Where pobiera WSZYSTKIE pola z bazy
            User user = connect.Users.Where(x => x.Id == 1).FirstOrDefault();
            user.Name = "AlaMaKota";
            connect.SaveChanges();
        }

        /// <summary>
        /// Edycja tylko jednego parametru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditUser2_Click(object sender, EventArgs e)
        {
            //tutaj edytujemy tylko jedno pole bez pobierania wszystkich
            // Id = 2 MUSI ISTNIEC TAKIE ID W BAZIE
            User user = new User() {Id = 2, Name = "Edycja2"};
            //connect.Users.Attach laczymy obiekt user z istniejacym w bazie po Id (Key)
            connect.Users.Attach(user);
            //ustalamy jakie pole ma byc edytowane
            connect.Entry(user).Property(u => u.Name).IsModified = true;
            connect.SaveChanges();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int userId = 10;
            User user = GetUser(userId);
            //List<Article> articles = connect.Articles.Where(a => a.UserIdFK == userId).ToList();

            //foreach (var article in user.Articles)
            //    connect.Articles.Remove(article);

            connect.Users.Remove(user);
            connect.SaveChanges();
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            User user = new User() {Name = "user article"};
            connect.Users.Add(user);
            connect.Articles.Add(new Article() { ArticleId = 2,  User = user });
            connect.SaveChanges();
        }

        private User GetUser(int id)
        {
            User user = connect.Users.Where(u => u.Id == id).Include(a => a.Articles).FirstOrDefault();
            return user;
        }
    }
}
