using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Content.Res;
using AndroidX.AppCompat.App;
using System.IO;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection.Emit;
using Google.Android.Material.BottomNavigation;

namespace CarouseAndroid
{

    [Activity(Label = "@string/app_name", Theme = "@style/Theme.Design.Light.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            ActionBar.Hide();
            Button potion = (Button)FindViewById(Resource.Id.btnpotion);
            potion.Click += Potion_Click;
            Button magicItem = (Button)FindViewById(Resource.Id.btnmagicitem);
            magicItem.Click += MagicItem_Click;
            Button carouse = (Button)FindViewById(Resource.Id.btncarousing);
            carouse.Click += Carouse_Click;
            Button race = (Button)FindViewById(Resource.Id.btnrace);
            race.Click += Race_Click;            
            //Changed button names her, because it was swapping 
        }


        private void Carouse_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            string filename = "BigTable.txt";
            AssetManager assets = Android.App.Application.Context.Assets;
            using (StreamReader reader = new StreamReader(assets.Open(filename)))
            {
                text = reader.ReadToEnd();
            }
            List<string> carousingTable = new List<string>();
            carousingTable = text.Split('\n').ToList();
            Random d200 = new Random();
            int result = d200.Next(1, 200);
            TextView carouseResult = (TextView)FindViewById(Resource.Id.textView5);
            carouseResult.Text = carousingTable[result];
            Add_To_Log(carousingTable[result]);
        }

        private void MagicItem_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            string filename = "Magicitems.txt";
            AssetManager assets = Android.App.Application.Context.Assets;
            using (StreamReader reader = new StreamReader(assets.Open(filename)))
            {
                text = reader.ReadToEnd();
            }
            List<string> magicItems = new List<string>();
            magicItems = text.Split('\n').ToList();
            Random d1343 = new Random();
            int result = d1343.Next(1, 1343);
            TextView magicItemResult = (TextView)FindViewById(Resource.Id.textView2);
            magicItemResult.Text = magicItems[result];
            Add_To_Log(magicItems[result]);
        }

        private void Potion_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            string filename = "Potion.txt";
            AssetManager assets = Application.Context.Assets;
            using (StreamReader reader = new StreamReader(assets.Open(filename)))
            {
                text = reader.ReadToEnd();
            }
            List<string> potionTable = new List<string>();
            potionTable = text.Split('\n').ToList();
            Random d59 = new Random();
            int result = d59.Next(1, 59);
            TextView Potionresult = (TextView)FindViewById<TextView>(Resource.Id.textView1);
            Potionresult.Text = potionTable[result];
            Add_To_Log(potionTable[result]);
        }

        private void Race_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            string fileName = "races.txt";
            AssetManager assets = Application.Context.Assets;
            using (StreamReader reader = new StreamReader(assets.Open(fileName)))
            {
                text = reader.ReadToEnd();
            }
            List<string> raceTable = new List<string>();
            raceTable = text.Split('\n').ToList();
            Random d60 = new Random();
            int result = d60.Next(1, 60);
            string Raceresult = raceTable[result];
            TextView race = (TextView)FindViewById<TextView>(Resource.Id.textView4);
            race.Text = Raceresult;
            Add_To_Log(raceTable[result]);
        }
        private void Add_To_Log(string input)
        {
            TextView logView = FindViewById<TextView>(Resource.Id.textView3);
            logView.Text += ("\n"+input);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

       
    }
}