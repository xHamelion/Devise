using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;
using Devise;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace UnitTest_Device
{
    [TestClass]
    public class DeviseUnitTest
    {
        [TestMethod]
        public void Test_PDF_Created_True()
        {
            
            var form = new F_Pokup();
            form.Show();
            Holder.UnitTest_Put = @"C:\Users\xHamelion\Desktop\Test.PDF";
            new PDF(form.dataGridView1, "Test");
            Assert.IsTrue(File.Exists(@"C:\Users\xHamelion\Desktop\Test.PDF"));
            form.Close();
        }

        [TestMethod]
        public void Test_Chec_Created_True()
        {
            string put = @"C:\Users\xHamelion\Desktop\Test_Check";
            Holder.TestTatus = true;
            var form = new F_Vibitie_Naklad();
            form.Show();
            form.viewNakladProdagBindingSource.Position = 0;
            Holder.UnitTest_Put = put;

            //form.button1_Click(null, null);
            form.check();
            Assert.IsTrue(File.Exists(put+".pdf"));
            File.Delete(put + ".pdf");
            form.Close();
        }

        [TestMethod]
        public void Test_Auvtorization_True()
        {

            var form = new F_Login();
            form.Show();
            form.BTN_Vhod_Reg.Text = "Вход";
            form.BTN_Vhod_Reg_Click(null,null);
            Assert.IsNotNull(Holder.securityName);
            form.Close();
        }
        [TestMethod]
        public void Test_Auvtorization_False()
        {

            var form = new F_Login();
            form.Show();
            form.TB_Log.Text = "NonLOginTest";
            form.BTN_Vhod_Reg.Text = "Вход";
            form.BTN_Vhod_Reg_Click(null, null);
            Assert.IsFalse(form.author);
            form.Close();
        }

        [TestMethod]
        public void Test_Auvtorization_Administrator_Dotup()
        {

            var form = new F_Login();
            form.Show();
            form.BTN_Vhod_Reg.Text = "Вход";
            form.BTN_Vhod_Reg_Click(null, null);
            Assert.IsTrue((Application.OpenForms[1] as F_Menu).BTN_Add_Reg.Enabled);
            form.Close();
           
        }

        [TestMethod]
        public void Test_Auvtorization_Prodavec_Dotup()
        {
            var form = new F_Login();
            form.Show();
            form.BTN_Vhod_Reg.Text = "Вход";
            string login_pas = "1";
            form.TB_Log.Text = login_pas;
            form.TB_Porol.Text = login_pas;
            form.BTN_Vhod_Reg_Click(null, null);
            Assert.IsTrue((Application.OpenForms[Application.OpenForms.Count - 1] as F_Menu).button9.Enabled);
            Assert.IsFalse((Application.OpenForms[Application.OpenForms.Count-1] as F_Menu).BTN_Add_Reg.Enabled);
            form.Close();
        }

        [TestMethod]
        public void Test_Auvtorization_Pokup_Dotup()
        {
            var form = new F_Login();
            form.Show();
            form.BTN_Vhod_Reg.Text = "Вход";
            string login_pas = "2";
            form.TB_Log.Text = login_pas;
            form.TB_Porol.Text = login_pas;
            form.BTN_Vhod_Reg_Click(null, null);
            Assert.IsFalse((Application.OpenForms[Application.OpenForms.Count - 1] as F_Menu).button9.Enabled);
            Assert.IsFalse((Application.OpenForms[Application.OpenForms.Count - 1] as F_Menu).BTN_Add_Reg.Enabled);
            Assert.IsTrue((Application.OpenForms[Application.OpenForms.Count - 1] as F_Menu).button8.Enabled);
            form.Close();
        }

        [TestMethod]
        public void Test_Connetction()
        {
            SqlConnection ms = new Connection().Sql();
            ms.Open();
            Assert.IsNotNull(new SqlCommand($"select * from Reg",ms).ExecuteNonQuery());
            ms.Close();
        }

        [TestMethod]
        public void Test_Sklad_Update_Partii()
        {
            Holder.TestTatus = true;
            SqlConnection ms = new Connection().Sql();
            ms.Open();
            SqlCommand com = new SqlCommand($"update Sklad set Koll = '0'", ms);
            com.ExecuteNonQuery();
            ms.Close();

            var form = new F_Sklad();
            form.Show();

            var form2 = new F_Sklad();
            form2.Show();
            form2.button3_Click(null, null);
            Assert.AreNotEqual(form2.dataGridView1[8,0].Value, form.dataGridView1[8, 0].Value);
            form.Close();
            form2.Close();
        }


        [TestMethod]
        public void Test_Exeption_Dlinna()
        {
            var form = new F_D_R_Postavhick();
            form.BTN_Red_Save.Text = "Сохранить";
            form.TB_Naim_Org.Text = "Test_Not_Add";
            form.MTB_Telef.Text = "";
            form.BTN_Red_Save_Click(null, null);
            SqlConnection ms = new Connection().Sql();
            ms.Open();
            SqlCommand com = new SqlCommand($"select * from Postavhick where(Naimenovanie_Organiz = '{form.TB_Naim_Org.Text}')", ms);
            Assert.AreEqual(Convert.ToInt32( com.ExecuteScalar()),0);
        }

    }
}
