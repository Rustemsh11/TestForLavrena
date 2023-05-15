using System.Net;
using System.IO;
using WeatherWinFormsApp.OpenWeather;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WeatherWinFormsApp
{
    public partial class Form1 : Form
    {
        private const string APIKEY = "ebda0b0cbcbf09f3f2c3d736d7f14af7"; 

        public Form1()
        {
            InitializeComponent();            
        }

        
        private async void GetWeatherButton_Click(object sender, EventArgs e)
        {
            ClearLabel(); // ������ ������ ��������

            string city = CityTextBox.Text;
            await GetWeather(city); // ������� ����� ������

        }

        /// <summary>
        /// �������� ����� ��������� ������ �� API 
        /// </summary>
        /// <param name="cityName">�������� ������ ���������� �� ����������</param>
      
        private  async Task GetWeather(string cityName)
        {
            WebRequest request = WebRequest.Create($"http://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&APPID={APIKEY}"); // ������ ������
            WebResponse webResponse = await request.GetResponseAsync();  // ������� ����� �� ������� 

            string answer = await GetAnswerFromResponse(webResponse);  // ������� ����� � ���� ������

            GetResult(answer); 

            webResponse.Close();
        }

        /// <summary>
        /// ������� ����� �� ������ 
        /// </summary>
        /// <param name="response">����� �� �������</param>    
        private  async Task<string> GetAnswerFromResponse(WebResponse response)
        {
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))  
            {
                return await stream.ReadToEndAsync(); // ��������� ������ ������
            }
        }
        /// <summary>
        /// �������� ��������� ������������� ����� � ��������� � ������
        /// </summary>
        /// <param name="answer">����� ���������� �� ������</param>
        private void GetResult(string answer)
        {
            WeatherInfo weather = JsonConvert.DeserializeObject<WeatherInfo>(answer);

            TempLabel.Text += $"{weather.Main.Temp.ToString("0.##")} �C ";
            DescriptionLabel.Text += $"{weather.Weather[0].Description}"; 
            WindSeedLabel.Text +=$"{weather.Wind.Speed.ToString()} �/�";


        }

        /// <summary>
        /// ������ ������ ������ ������ ������
        /// </summary>
        private void ClearLabel()
        {
            TempLabel.Text = "�����������: ";
            DescriptionLabel.Text = "��������: ";
            WindSeedLabel.Text = "�������� �����: ";
        }
                
    }
}