using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using RSS_reader.Classes;
using RSS_reader;

namespace RSS_reader
{
    public partial class AuthenticationForm : Form
    {
        //Путь к веб серверу 
        //тип формы: false - авторизации, true - регистрации
        private bool TypeForm = false;
        

        public AuthenticationForm()
        {
            InitializeComponent();
            ErrorMessage.Text = "";
        }

        //изменение типа формы
        private void ChangeType()
        {
            //инвертировать значение
            TypeForm ^= true;

            //переобразовать форму в зависимость от типа
            if (TypeForm)
            {
                ChangeTypeLabel.Text = "Authorization";
                Caption.Text = "Registration";
                ConfirmLabel.Visible = true;
                ConfirmField.Visible = true;
            }
            else
            {
                ChangeTypeLabel.Text = "Regsitration";
                Caption.Text = "Authorization";
                ConfirmLabel.Visible = false;
                ConfirmField.Visible = false;
            }
            ErrorMessage.Text = "";
        }

        //вызов изменения типа формы
        private void ChangeType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeType();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string Email = EmailField.Text;
            string Password = PasswordField.Text;
            string Confirm = ConfirmField.Text;

            //Проверка введенных данных
            if (Email.Length < 4)
            {
                ErrorMessage.Text = "Too short login";
                return;
            }
            if (Password.Length < 4)
            {
                ErrorMessage.Text = "Too short password";
                return;
            }
            if (TypeForm & String.Compare(Password, Confirm) !=0)
            {
                ErrorMessage.Text = "Incorrect data";
                return;
            }
            if(TypeForm)
            {
                if(String.Compare(InterplayForServer.Register(Email, Password), "OK") == 0)
                {
                    MessageBox.Show("Successful registration!!! \n Now authorized");
                    ChangeType();
                    EmailField.Text = "";
                    PasswordField.Text = "";
                    ConfirmField.Text = "";
                }
                else
                {
                    ErrorMessage.Text = "Registration error";
                }
            }
            else
            {
                if(String.Compare(InterplayForServer.Authorization(Email, Password), "OK") == 0)
                {
                    this.Close();
                }
                else
                {
                    ErrorMessage.Text = "Authorisation error";
                }
            }
        }
    }
}
