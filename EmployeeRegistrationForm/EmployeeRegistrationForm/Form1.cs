﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeRegistrationForm
{
    public partial class Form1 : Form
    {
        public static string fname;
        public static string myJson;
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }




        private void submit_Click(object sender, EventArgs e)
        {
            fname = firstname.Text.ToString();



            var request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/employee");
            request.ContentType = "application/json";
            request.Method = "POST";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                myJson = 
    "{\"First Name\""+":"+ "\"Rakshit\"," +
    "\"Middle Name\"" + ":" + "\"Ashok\"," +
    "\"Last Name\"" + ":" + "\"Popat\"," +
    "\"Address\"" + ":" + "\"Sumul Dairy Road\"," +
    "\"State\"" + ":" + "\"Gujarat\"," +
    "\"Phone number\"" + ":" + "\"7698910973\"," +
    "\"Email\"" + ":" + "\"rajpopat27@gmail.com\"," +
    "\"Date of birth\"" + ":" + "\"1996-01-01\"," +
    "\"Linkedin Id\"" + ":" + "\"www.linkedin.com/rajpopat27\"," +
    "\"Blood group\"" + ":" + "\"A+\"," +
    "\"Aadhar number\"" + ":" + "\"025165213214\"," +
    "\"Experience years\"" + ":" + "\"2\"," +
    "\"Employee type\"" + ":" + "\"manager\"," +
    "\"Employee post\"" + ":" + "\"manager\"," +
    "\"Shift name\"" + ":" + "\"first\"," +
    "\"Salary\"" + ":" + "\"10000\"," +
    "\"Pincode\"" + ":" + "\"350004\"," +
    "\"Department\"" + ":" + "\"IT\"," +
    "\"Iris Id\"" + ":" + "[76, 110, 114, 101, 109, 32, 105, 112, 115, 117, 109, 32, 100, 111, 108, 111, 114, 32, 115, 105, 116, 32, 97, 109, 101, 116, 44, 32, 99, 111, 110, 115, 101, 99, 116, 101, 116, 117, 114, 32, 97, 100, 105, 112, 105, 115, 99, 105, 110, 103, 32, 101, 108, 105, 116, 46, 32, 73, 110, 116, 101, 103, 101, 114, 32, 105, 110, 32, 97, 108, 105, 113, 117, 101, 116, 32, 106, 117, 115, 116, 111, 46, 32, 65, 101, 110, 101, 97, 110, 32, 115, 111, 100, 97, 108, 101, 115, 32, 118, 101, 108, 105, 116, 32, 110, 101, 99, 32, 101, 120, 32, 112, 117, 108, 118, 105, 110, 97, 114, 44, 32, 115, 101, 100, 32, 100, 97, 112, 105, 98, 117, 115, 32, 108, 101, 111, 32, 97, 108, 105, 113, 117, 101, 116, 46, 32, 80, 114, 97, 101, 115, 101, 110, 116, 32, 97, 32, 100, 105, 97, 109, 32, 101, 117, 32, 116, 111, 114, 116, 111, 114, 32, 109, 97, 120, 105, 109, 117, 115, 32, 112, 117, 108, 118, 105, 110, 97, 114, 46, 32, 65, 101, 110, 101, 97, 110, 32, 100, 105, 97, 109, 32, 111, 114, 99, 105, 44, 32, 115, 97, 103, 105, 116, 116, 105, 115, 32, 110, 111, 110, 32, 109, 97, 103, 110, 97, 32, 97, 99, 44, 32, 99, 111, 110, 100, 105, 109, 101, 110, 116, 117, 109, 32, 97, 108, 105, 113, 117, 101, 116, 32, 114, 105, 115, 117, 115, 46, 32, 85, 116, 32, 97, 32, 100, 111, 108, 111, 114, 32, 118, 101, 108, 32, 97, 114, 99, 117, 32, 115, 111, 100, 97, 108, 101, 115, 32, 99, 117, 114, 115, 117, 115, 46, 32, 70, 117, 115, 99, 101, 32, 115, 117, 115, 99, 105, 112, 105, 116, 32, 118, 101, 115, 116, 105, 98, 117, 108, 117, 109, 32, 100, 105, 97, 109, 32, 115, 105, 116, 32, 97, 109, 101, 116, 32, 117, 108, 116, 114, 105, 99, 105, 101, 115, 46, 32, 67, 117, 114, 97, 98, 105, 116, 117, 114, 32, 117, 108, 108, 97, 109, 99, 111, 114, 112, 101, 114, 32, 97, 114, 99, 117, 32, 115, 97, 112, 105, 101, 110, 44, 32, 115, 105, 116, 32, 97, 109, 101, 116, 32, 112, 117, 108, 118, 105, 110, 97, 114, 32, 100, 117, 105, 32, 109, 97, 108, 101, 115, 117, 97, 100, 97, 32, 101, 117, 46, 32, 69, 116, 105, 97, 109, 32, 105, 97, 99, 117, 108, 105, 115, 32, 110, 105, 115, 105, 32, 110, 111, 110, 32, 116, 105, 110, 99, 105, 100, 117, 110, 116, 32, 102, 105, 110, 105, 98, 117, 115, 46, 32, 80, 114, 111, 105, 110, 32, 109, 97, 108, 101, 115, 117, 97, 100, 97, 32, 118, 101, 104, 105, 99, 117, 108, 97, 32, 100, 111, 108, 111, 114, 44, 32, 118, 105, 116, 97, 101, 32, 115, 97, 103, 105, 116, 116, 105, 115, 32, 110, 105, 98, 104, 32, 103, 114, 97, 118, 105, 100, 97, 32, 115, 111, 108, 108, 105, 99, 105, 116, 117, 100, 105, 110, 46, 32, 80, 101, 108, 108, 101, 110, 116, 101, 115, 113, 117, 101, 32, 118, 101, 108, 32, 118, 97, 114, 105, 117, 115, 32, 100, 117, 105, 44, 32, 110, 101, 99, 32, 102, 101, 114, 109, 101, 110, 116, 117, 109, 32, 117, 114, 110, 97, 46, 32, 73, 110, 32, 100, 105, 103, 110, 105, 115, 115, 105, 109, 44, 32, 100, 117, 105, 32, 117, 116, 32, 115, 101, 109, 112, 101, 114, 32, 112, 111, 114, 116, 116, 105, 116, 111, 114, 44, 32, 102, 101, 108, 105, 115, 32, 101, 114, 111, 115, 32, 118, 101, 104, 105, 99, 117, 108, 97, 32, 101, 115, 116, 44, 32, 97, 116, 32, 118, 101, 110, 101, 110, 97, 116, 105, 115, 32, 108, 105, 103, 117, 108, 97, 32, 115, 101, 109, 32, 118, 105, 116, 97, 101, 32, 108, 105, 103, 117, 108, 97, 46, 32, 73, 110, 32, 110, 105, 115, 105, 32, 111, 114, 99, 105, 44, 32, 101, 108, 101, 109, 101, 110, 116, 117, 109, 32, 118, 101, 108, 32, 109, 97, 103, 110, 97, 32, 111, 114, 110, 97, 114, 101, 44, 32, 112, 101, 108, 108, 101, 110, 116, 101, 115, 113, 117, 101, 32, 117, 108, 116, 114, 105, 99, 105, 101, 115, 32, 112, 117, 114, 117, 115, 46, 32]}";

                streamWriter.Write(myJson);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                label3.Text = result;
            }
            
        }
    }
}
