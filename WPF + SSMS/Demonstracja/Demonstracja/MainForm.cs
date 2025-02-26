using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demonstracja
{
    public partial class MainForm : Form
    {
        public string userRole;
        public string curUser;
        public MainForm(string currentUser,string role)
        {
             InitializeComponent();
             userRole = role;

             curUser = currentUser;

             SetBtnVisible();
             roleUser.Text = role;
        }

        private void SetBtnVisible()
        {
            // Скрываем кнопки для сотрудника, если роль - Админ
            if (userRole.ToLower() == "админ")
            {
                // Для администратора показываем все кнопки
                GuestsBtn.Visible = true;
                ClientsBtn.Visible = true;
                RoomsBtn.Visible = true;
                UsersBtn.Visible = true;
                PassChangeBtn.Visible = true;   
            }
            else if (userRole.ToLower() == "сотрудник")
            {
                // Для сотрудника скрываем кнопки, которые доступны только администратору
                GuestsBtn.Visible = true;
                ClientsBtn.Visible = true;
                RoomsBtn.Visible = true;
                UsersBtn.Visible = false;
                PassChangeBtn.Visible = true;
            }

        }

        private void GuestsBtn_Click(object sender, EventArgs e)
        {
            Guests guests = new Guests();
            guests.Show();
        }

        private void ClientsBtn_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
        }

        private void RoomsBtn_Click(object sender, EventArgs e)
        {
            RoomStock roomStock = new RoomStock();
            roomStock.Show();
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
        }

        private void PassChangeBtn_Click(object sender, EventArgs e)
        {
            PassChange passChange = new PassChange(curUser);
            passChange.Show();
        }

        private void recordsBtn_Click(object sender, EventArgs e)
        {
            Records records = new Records();
            records.Show();
        }
    }
}
