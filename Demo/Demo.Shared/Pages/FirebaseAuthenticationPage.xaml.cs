﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirebaseDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirebaseAuthenticationPage : ContentPage
    {
        public string Email { get; set; }
        public string Password { get; set; }
        //private IFirebaseAuth _firebaseAuth;

        public FirebaseAuthenticationPage()
        {
            //_firebaseAuth = DependencyService.Get<IFirebaseAuth>();
            InitializeComponent();
            BindingContext = this;
        }

        private async void OnSignIn(object sender, EventArgs e)
        {
            //await _firebaseAuth.LoginWithEmailPassword(Email, Password);
        }

        private async void OnCreate(object sender, EventArgs e)
        {
            //await _firebaseAuth.CreateAccount(Email, Password);
        }

        private async void OnResetPassword(object sender, EventArgs args)
        {
            //await _firebaseAuth.SendPasswordResetEmail(Email);
        }
    }
}