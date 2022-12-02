using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        FileStream fs;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\student.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Student student = new Student();
               student.Rollno = Convert.ToInt32(txtrollno.Text);
                student.Name = txtname.Text;
                student.Perc=Convert.ToInt32( txtperc.Text);
                binaryFormatter.Serialize(fs, student);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }


        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\student.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Student student = new Student();
                student = (Student)binaryFormatter.Deserialize(fs);
                txtrollno.Text = student.Rollno.ToString();
                txtname.Text = student.Name;
                txtperc.Text = student.Perc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }


        }

        private void btnxmlwrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\student.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                Student student = new Student();
                student.Rollno = Convert.ToInt32(txtrollno.Text);
                student.Name = txtname.Text;
                student.Perc = Convert.ToInt32(txtperc.Text);
                xmlSerializer.Serialize(fs, student);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }




        }

        private void btnxmlread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\student.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                Student student = new Student();
                student = (Student)xmlSerializer.Deserialize(fs);
                txtrollno.Text = student.Rollno.ToString();
                txtname.Text = student.Name;
                txtperc.Text = student.Perc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\student.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Student student = new Student();
                student.Rollno = Convert.ToInt32(txtrollno.Text);
                student.Name = txtname.Text;
                student.Perc = Convert.ToInt32(txtperc.Text);
                soapFormatter.Serialize(fs, student);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnsoapread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\student.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Student student = new Student();
                student = (Student)soapFormatter.Deserialize(fs);
                txtrollno.Text = student.Rollno.ToString();
                txtname.Text = student.Name;
                txtperc.Text = student.Perc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }


        }

        private void btnjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\student.json", FileMode.Create, FileAccess.Write);
                Student student = new Student();
                student.Rollno = Convert.ToInt32(txtrollno.Text);
                student.Name = txtname.Text;
                student.Perc = Convert.ToInt32(txtperc.Text);
                JsonSerializer.Serialize<Student>(fs,student);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }


        }

        private void btnjsonread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\student.json", FileMode.Open, FileAccess.Read);
                Student student = new Student();
                student = JsonSerializer.Deserialize<Student>(fs);
                txtrollno.Text = student.Rollno.ToString();
                txtname.Text = student.Name;
                txtperc.Text = student.Perc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }
    }
}
