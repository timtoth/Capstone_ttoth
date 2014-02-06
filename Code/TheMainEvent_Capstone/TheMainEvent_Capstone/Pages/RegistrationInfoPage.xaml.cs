﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TheMainEvent_Capstone.Model;
using TheMainEvent_Capstone.DataAccessLayer;
using Parse;
using System.Windows.Input;

namespace TheMainEvent_Capstone.Pages
{
	public partial class RegistrationInfoPage : PhoneApplicationPage
	{
		public RegistrationInfoPage()
		{
			InitializeComponent();
			phoneBox.Tap += this.TextBox_Tap;
			lastNameBox.Tap += this.TextBox_Tap;
			firstNameBox.Tap += this.TextBox_Tap;
			bioBox.Tap += this.TextBox_Tap;

			
		}
		private void TextBox_Tap(object sender, System.Windows.Input.GestureEventArgs e)
		{
			TextBox box = (TextBox)sender;
			if (box.Text.Equals("First Name") || box.Text.Equals("Last Name") || box.Text.Equals("Bio") || box.Text.Equals("Phone Number"))
			{
				box.Text = "";
			}
		}
		private void OnTextInputStart(object sender, TextCompositionEventArgs e)
		{
			scrollViewer.UpdateLayout();
			scrollViewer.ScrollToVerticalOffset(bioBox.ActualHeight);
		}

		private void doneButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				DateTime bday = (DateTime)datePicker.Value;
				string firstName = this.firstNameBox.Text;
				string lastName = this.lastNameBox.Text;
				string phoneNumber = this.phoneBox.Text;
				string bio = this.bioBox.Text;
				UserInfo ui = new UserInfo()
				{
					FirstName = firstName,
					LastName = lastName,
					Phone = phoneNumber,
					Bio = bio,
					Birthday = bday,
					User = ParseUser.CurrentUser.ObjectId,
					MerchantEmail = "tim.toth13@gmail.com"
				};
				UserDAL ud = new UserDAL();
				ud.CreateUserInfo(ui);
			}
			catch (Exception ex)
			{
			}
		}
	}
}