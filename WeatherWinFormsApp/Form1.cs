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
            ClearLabel(); // ощищаю старые значения

            string city = CityTextBox.Text;
            await GetWeather(city); // получаю новые данные

        }

        /// <summary>
        /// основной метод получения данных из API 
        /// </summary>
        /// <param name="cityName">название города полученный из текстбокса</param>
      
        private  async Task GetWeather(string cityName)
        {
            WebRequest request = WebRequest.Create($"http://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&APPID={APIKEY}"); // создаю запрос
            WebResponse webResponse = await request.GetResponseAsync();  // получаю ответ из запроса 

            string answer = await GetAnswerFromResponse(webResponse);  // получаю ответ в виде строки

            GetResult(answer); 

            webResponse.Close();
        }

        /// <summary>
        /// получаю ответ из потока 
        /// </summary>
        /// <param name="response">ответ из запроса</param>    
        private  async Task<string> GetAnswerFromResponse(WebResponse response)
        {
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))  
            {
                return await stream.ReadToEndAsync(); // возвращаю строку ответа
            }
        }
        /// <summary>
        /// формирую результат диссериализуя ответ и записывая в лейблы
        /// </summary>
        /// <param name="answer">ответ полученный из потока</param>
        private void GetResult(string answer)
        {
            WeatherInfo weather = JsonConvert.DeserializeObject<WeatherInfo>(answer);

            TempLabel.Text += $"{weather.Main.Temp.ToString("0.##")} °C ";
            DescriptionLabel.Text += $"{weather.Weather[0].Description}"; 
            WindSeedLabel.Text +=$"{weather.Wind.Speed.ToString()} м/с";


        }

        /// <summary>
        /// ощищаю лейблы удалив старые данные
        /// </summary>
        private void ClearLabel()
        {
            TempLabel.Text = "Температура: ";
            DescriptionLabel.Text = "Описание: ";
            WindSeedLabel.Text = "Скорость ветра: ";
        }
                
    }
}