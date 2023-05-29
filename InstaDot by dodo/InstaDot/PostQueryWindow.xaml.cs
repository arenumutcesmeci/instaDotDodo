using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using InstagramApiSharp;
using InstagramApiSharp.API.Processors;
using InstagramApiSharp.Classes;

namespace InstaDot;

public partial class PostQueryWindow : UserControl
{
    private readonly MainWindow _instance;
    private readonly IUserProcessor _userProcessor;
    private readonly IMediaProcessor _mediaProcessor;
    public PostQueryWindow(MainWindow mainWindow)
    {
        InitializeComponent();
        _instance = mainWindow;
        _userProcessor = _instance.Api!.UserProcessor;
        _mediaProcessor = _instance.Api!.MediaProcessor;
    }

    private async Task Load_Data()
    {
        var postUrl = UrlTxt.Text;
        if(postUrl == string.Empty)
        {
            MessageBox.Show("Lütfen bir post urlsi giriniz.", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        
        var postId = await _mediaProcessor.GetMediaIdFromUrlAsync(new Uri(postUrl));
        if (!postId.Succeeded || postId.Value == null)
        {
            if (postId.Info.ResponseType == ResponseType.LoginRequired)
            {
                MessageBox.Show("Giriş yapmanız gerekiyor.", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
                _instance.LoggedOut();
                return;
            }
            
            MessageBox.Show("Post bulunamadı.", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        var post = await _mediaProcessor.GetMediaByIdAsync(postId.Value);

        if (!post.Succeeded || post.Value == null)
        {
            if (post.Info.ResponseType == ResponseType.LoginRequired)
            {
                MessageBox.Show("Giriş yapmanız gerekiyor.", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
                _instance.LoggedOut();
                return;
            }
            
            MessageBox.Show("Post bulunamadı.", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        
        
        
        var postValue = post.Value;
        /*var likers = await _mediaProcessor.GetMediaLikersAsync(postId.Value);
        if (likers.Succeeded && likers.Value != null)
        {
            LikeCount.Content = $"Beğenen Sayısı: {likers.Value.Count}";
            //FollowLikers.IsEnabled = true;
        }
        else
        {
            LikeCount.Content = "Beğenen Sayısı: Hata";
            //FollowLikers.IsEnabled = false;
        }*/
        PostContent.Source = new Uri(postValue.Images.Any() ? postValue.Images.First().Uri : postValue.Videos.Any() ? postValue.Videos.First().Uri : string.Empty); 
        //PostContent.Play();
    }

    private async void RefreshBtn_OnClick(object sender, RoutedEventArgs e)
    {
        await Load_Data();
    }

    private async void SearchBtn_OnClick(object sender, RoutedEventArgs e)
    {
        await Load_Data();
    }
}