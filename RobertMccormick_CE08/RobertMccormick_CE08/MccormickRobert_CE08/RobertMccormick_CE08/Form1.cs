//Robert Mccormick
//Frameworkds
//Term3
//RobertMcCormick_CE08

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MccormickRobert_JSONandAPI.mods;
using System.Xml;
using System.Xml.Serialization;




namespace MccormickRobert_JSONandAPI
{
    public partial class Form1 : Form
    {
        //unique key for validate input text file
        private const string KEY = "My Program";

        WebClient apiConnection = new WebClient();

        private Weather weather;

        string apiStartingPoint = "http://api.wunderground.com/api/b513344ce4d46def/conditions/q/";

       
        //API ending point 
        string apiEndPoint;


        public Form1()
        {
            InitializeComponent();

            weather = new Weather();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string ReturnStateAbbrev()
        {
            string abbrev = "";
            string[] stateAbbrev = new string[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };

            //match the state to the abbreviation 
            abbrev = stateAbbrev[cmbState.SelectedIndex];

            return abbrev;
        }




        private void BuildAPI()
        {
            //Get the state abbreviation 
            string abbrev = ReturnStateAbbrev();

            //replace any spaces in the city 
            string city = txtCity.Text.Replace(' ', '_');

            string jsonOrXml = ".xml";
            if (rdoJSON.Checked)
            {
                jsonOrXml = ".json";
            }

            //complete the API 
            apiEndPoint = apiStartingPoint + abbrev + "/" + city + jsonOrXml;   // city + ".json";
 
        
        }

        private void btnViewWeatherData_Click(object sender, EventArgs e)
        {
             
                try
                {
                    BuildAPI();

                    //call the correct method 

                    if (rdoJSON.Checked)
                    {
                        ReadTheJSON();
                    }
                    else { ReadTheXML(); }

                    //ReadTheData();
                    ApplyView(weather);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("No Internet connection!");
                }

            }
         

       

        private void ReadTheXML()
        {
            XmlTextReader apiData = new XmlTextReader(apiEndPoint);
            weather = new Weather();

            //create variables to hold data 
            int i = 0;
            string city = "";
            string temp = "";
            string feelslike = "";
            string humidity = "";
            string windMPH = "";
            string state = "";

            while (apiData.Read())
            {
                //when we find the "city" name
                if (apiData.Name == "city"  && i==0)
                {
                    i = 1;
                    //get the city string 
                    city = apiData.ReadString();
                   
                    //show it in a message box
               //     MessageBox.Show("City: " + city);
                }

                if (apiData.Name == "state")
                {
                    state = apiData.ReadString();
                }
                if (apiData.Name == "temp_f")
                {
                    temp = apiData.ReadString();
                }

                if (apiData.Name == "feelslike_f")
                {
                    feelslike = apiData.ReadString();
                }

                if (apiData.Name == "relative_humidity")
                {
                    humidity = apiData.ReadString();
                }
                if (apiData.Name == "wind_mph")
                {
                    windMPH = apiData.ReadString();
                }

            }

            weather.CurrTemp = Convert.ToDecimal(temp);
            weather.FeelsTemp = Convert.ToDecimal(feelslike);// weather.CurrTemp  numTemp.Value            
            weather.WindSpeed = Convert.ToDecimal(windMPH);
            weather.RelativeHumidity = Convert.ToDecimal(humidity.Substring(0, humidity.Length - 1));
            weather.City = city;
            weather.State = state; 

          ApplyView(weather);
            ApplyModel();

        }


        private void ReadTheJSON() //ReadTheData()
        {
            
            

            // download data as string 
            var apiData = apiConnection.DownloadString(apiEndPoint);
            //see the string 
            JObject o = JObject.Parse(apiData);

  
            weather = new Weather();


            weather.CurrTemp = Convert.ToDecimal(o["current_observation"]["temp_f"]);
            weather.FeelsTemp = Convert.ToDecimal(o["current_observation"]["feelslike_f"]);
            string relativeHumidity = o["current_observation"]["relative_humidity"].ToString();
            weather.RelativeHumidity = Convert.ToDecimal(relativeHumidity.Substring(0, relativeHumidity.Length - 1));
            weather.WindSpeed = Convert.ToDecimal(o["current_observation"]["wind_mph"]);
            weather.Direction = o["current_observation"]["wind_dir"].ToString();
            weather.City = o["current_observation"]["display_location"]["city"].ToString();
            weather.State = o["current_observation"]["display_location"]["state"].ToString();

            ApplyView(weather);
            ApplyModel();

        }



        private void ApplyView(Weather model)
        {

            numTemp.Value = model.CurrTemp;
            txtDirection.Text = model.Direction;
            numFeelsLikeTemp.Value = model.FeelsTemp;
            numRelativeHumidity.Value = model.RelativeHumidity;
            numWindSpeed.Value = model.WindSpeed;
            cmbState.Text = model.State;
            txtCity.Text = model.City;
        }

        private void ApplyModel()
        {
            weather.UniqueKey = KEY;

            weather.Direction = txtDirection.Text;
            weather.FeelsTemp = numFeelsLikeTemp.Value;
            weather.RelativeHumidity = numRelativeHumidity.Value;
            weather.CurrTemp = numTemp.Value;
            weather.WindSpeed = numWindSpeed.Value;
            weather.State = cmbState.Text;       //not working
            weather.City = txtCity.Text;         //load value into textbox

            //string _state = (weather.City + ", " + weather.State);          
            //textBox1.Text= _state;
        }

        private string GetExt(string filename)
        {
            var temp = filename.Split('.');
            return temp[temp.Length - 1];
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyModel();
            //deleted 274
            if (rdoXML.Checked)
            {
                saveFileDialog1.Filter = "xml files (*.xml)|*.xml";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    var serializer = new XmlSerializer(weather.GetType());
                    var xmlString = "";
                    using (StringWriter textWriter = new StringWriter())
                    {
                        serializer.Serialize(textWriter, weather);
                        xmlString = textWriter.ToString();

                        File.WriteAllText(saveFileDialog1.FileName, xmlString);
                        MessageBox.Show("Saved!");
                    }
                }
            }
            else //(rdoJSON.Checked)
            {
                //  Stream myStream;
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, JsonConvert.SerializeObject(weather));
                    MessageBox.Show("Saved!");
                    /*/*  myStream.Close();*/
                }
            }
        }



        


////////////////////  if (GetExt(saveFileDialog1.FileName).ToLower().Equals("xml"))
////////////////////                {
////////////////////                    var serializer = new XmlSerializer(weather.GetType());
////////////////////var xmlString = "";
////////////////////                    using (StringWriter textWriter = new StringWriter())
////////////////////                    {
////////////////////                        serializer.Serialize(textWriter, weather);
////////////////////                        xmlString = textWriter.ToString();

////////////////////                        File.WriteAllText(saveFileDialog1.FileName, xmlString);
////////////////////                        MessageBox.Show("Saved!");
////////////////////                    }
////////////////////                }

////////////////////                else   // if((myStream = saveFileDialog1.OpenFile()) != null) 
////////////////////                {

////////////////////                    File.WriteAllText(saveFileDialog1.FileName, JsonConvert.SerializeObject(weather));
////////////////////                    MessageBox.Show("Saved!");
////////////////////                    //myStream.Close();
////////////////////                }



 


private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //load data from file
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //load xml file


                    if (GetExt(openFileDialog1.FileName).ToLower().Equals("xml"))
                    {
                        using (StreamReader stream = new StreamReader(openFileDialog1.FileName))
                        {
                            var serializer = new XmlSerializer(weather.GetType());
                            weather = (Weather)serializer.Deserialize(stream);

                            //check KEY first
                            if (!KEY.Equals(weather.UniqueKey))
                            {
                                MessageBox.Show("Not valid text file!");
                                return;
                            }


                        }

                        ApplyView(weather);
                        ApplyModel();
                    }
                    else
                    //load txt file
                    {

                     //   weather = JsonConvert.DeserializeObject<Weather>(File.ReadAllText(openFileDialog1.FileName));

                        if (GetExt(openFileDialog1.FileName).ToLower().Equals("txt"))
                        {
                            weather = JsonConvert.DeserializeObject<Weather>(File.ReadAllText(openFileDialog1.FileName));
                        }
                       
                        //check KEY first

                        if (!KEY.Equals(weather.UniqueKey))
                        {
                            MessageBox.Show("Not valid text file!");
                            return;
                        }
                        ApplyView(weather);
                        ApplyModel();
                    }
                                    
                    ////ApplyView(weather);      // moved these from 391 to 388
                    ////ApplyModel();
                    MessageBox.Show("Loaded");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Please choose correct file format");
            }
        }


      

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            weather = new Weather();
            ApplyView(weather);
        }
    }
   }



 