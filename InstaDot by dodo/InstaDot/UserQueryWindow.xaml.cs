using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using InstagramApiSharp;
using InstagramApiSharp.API.Processors;
using InstagramApiSharp.Classes;

namespace InstaDot;

public partial class UserQueryWindow : UserControl
{
    private readonly MainWindow _instance;
    private readonly IUserProcessor _userProcessor;
    private List<long> _followers = new();
    private List<long> _followings = new();
    public UserQueryWindow(MainWindow mainWindow)
    {
        InitializeComponent();
        _instance = mainWindow;
        _userProcessor = _instance.Api!.UserProcessor;
    }

    private async Task Load_Data(string username)
    {
        var user = await _userProcessor.GetUserAsync(username);
        
        if(user.Succeeded && user.Value != null)
        { 
            var userValue = user.Value;
            var followers = await _userProcessor.GetUserFollowersAsync(userValue.UserName, PaginationParameters.MaxPagesToLoad(int.MaxValue));
            if (followers.Succeeded && followers.Value != null)
            {
                _followers = followers.Value.Select(x => x.Pk).ToList();
                Followers.Content = $"Takipçi Sayısı: {_followers.Count}";
                FollowFollowers.IsEnabled = true;
            }
            else
            {
                Followers.Content = "Takipçi Sayısı: Hata";
                FollowFollowers.IsEnabled = false;
            }
            var followings = await _userProcessor.GetUserFollowingAsync(userValue.UserName, PaginationParameters.MaxPagesToLoad(int.MaxValue));
            if (followings.Succeeded && followings.Value != null)
            {
                _followings = followings.Value.Select(x => x.Pk).ToList();
                Following.Content = $"Takip Edilen Sayısı: {_followings.Count}";
                FollowFollowings.IsEnabled = true;
            }
            else
            {
                Following.Content = "Takip Edilen Sayısı: Hata";
                FollowFollowings.IsEnabled = false;
            }
            Username.Content = $"@{userValue.UserName}";
            FullName.Content = $"{userValue.FullName}";
            //Biography.Content = userValue.
            if(userValue.ProfilePicture != null)
                ProfilePicture.Source = new BitmapImage(new Uri(userValue.ProfilePicture ?? userValue.ProfilePicUrl ?? ""));
        }
        else if (user.Info.ResponseType == ResponseType.LoginRequired)
        {
            _instance.LoggedOut();
        }
        else
        {
            FollowFollowers.IsEnabled = false;
            FollowFollowings.IsEnabled = false;
            MessageBox.Show("Kullanıcı bulunamadı.");
        }
    }

    private async void RefreshBtn_Click(object sender, RoutedEventArgs e)
    {
        var username = UsernameTxt.Text;
        if (username == "")
        {
            MessageBox.Show("Lütfen bir kullanıcı adı giriniz.");
            return;
        }
        
        await Load_Data(username.Trim().ToLower());
    }

    private async void SearchBtn_Click(object sender, RoutedEventArgs e)
    {
        var username = UsernameTxt.Text;
        if (username == "")
        {
            MessageBox.Show("Lütfen bir kullanıcı adı giriniz.");
            return;
        }
        await Load_Data(username.Trim().ToLower());
    }

    private async void FollowFollowers_OnClick(object sender, RoutedEventArgs e)
    {
        var username = UsernameTxt.Text;
        if (username == "")
        {
            MessageBox.Show("Lütfen bir kullanıcı adı giriniz.");
            return;
        }
        
        if (_followers.Count == 0)
        {
            MessageBox.Show("Takipçiler yüklenirken bir hata oluştu.");
            return;
        }

        var followCount = 0;

        foreach (var user in _followers)
        {
            var followResult = await _userProcessor.FollowUserAsync(user);
            if (!followResult.Succeeded)
            {
                if (followResult.Info.ResponseType == ResponseType.LoginRequired)
                {
                    MessageBox.Show("Oturumunuz işlem sırasında sonlandırıldı.");
                    _instance.LoggedOut();
                    return;
                }
            }
            else
            {
                followCount++;
            }
        }
        
        MessageBox.Show($"{followCount} kullanıcı takip edildi.");
    }

    private async void FollowFollowings_OnClick(object sender, RoutedEventArgs e)
    {
        var username = UsernameTxt.Text;
        if (username == "")
        {
            MessageBox.Show("Lütfen bir kullanıcı adı giriniz.");
            return;
        }
        
        if (_followings.Count < 1)
        {
            MessageBox.Show("Takip edilenler yüklenirken bir hata oluştu.");
            return;
        }
        
        var followCount = 0;

        foreach (var user in _followings)
        {
            var followResult = await _userProcessor.FollowUserAsync(user);
            if (!followResult.Succeeded)
            {
                if (followResult.Info.ResponseType == ResponseType.LoginRequired)
                {
                    MessageBox.Show("Oturumunuz işlem sırasında sonlandırıldı.");
                    _instance.LoggedOut();
                    return;
                }
            }
            else
            {
                followCount++;
            }
        }
        
        MessageBox.Show($"{followCount} kullanıcı takip edildi.");
    }
}