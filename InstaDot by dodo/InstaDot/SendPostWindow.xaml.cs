using System;
using System.Windows;
using System.Windows.Controls;
using InstagramApiSharp.API.Processors;
using InstagramApiSharp.Classes.Models;
using Microsoft.Win32;

namespace InstaDot;

public partial class SendPostWindow : UserControl
{
    private readonly MainWindow _instance;
    private string _filePath;
    private DateTime? _timingDate;
    private IMediaProcessor _mediaProcessor;
    public SendPostWindow(MainWindow mainWindow)
    {
        InitializeComponent();
        _instance = mainWindow;
        _filePath = string.Empty;
        _timingDate = null;
        _mediaProcessor = _instance.Api!.MediaProcessor;
    }

    private void RefreshBtn_OnClick(object sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void SelectMediaBtn_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFileDialog
        {
            Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
        };
        dialog.ShowDialog();
        
        if(dialog.FileName != string.Empty)
        {
            _filePath = dialog.FileName;
            Media.Source = new Uri(_filePath);
        }
    }

    private async void SendBtn_OnClick(object sender, RoutedEventArgs e)
    {
        if (!TimingDate.IsEnabled)
        {
            if(CaptionTxt.Text == String.Empty)
            {
                MessageBox.Show("Gönderi başlığı boş bırakılamaz.", "Hata");
                return;
            }
            
            if(_filePath == string.Empty)
            {
                MessageBox.Show("Gönderi için bir medya seçilmelidir.", "Hata");
                return;
            }

            var result = await _instance.Api.MediaProcessor.UploadPhotoAsync(new InstaImageUpload(_filePath), CaptionTxt.Text);

            if (!result.Succeeded)
            {
                MessageBox.Show("Gönderi gönderilirken bir hata oluştu.", "Hata");
                return;
            }
            
            MessageBox.Show("Gönderi başarıyla gönderildi.", "Başarılı");
        }
        else
        {
            if(CaptionTxt.Text == String.Empty)
            {
                MessageBox.Show("Gönderi başlığı boş bırakılamaz.", "Hata");
                return;
            }
            
            if(_filePath == string.Empty)
            {
                MessageBox.Show("Gönderi için bir medya seçilmelidir.", "Hata");
                return;
            }

            var result = await _instance.Api.MediaProcessor.UploadPhotoAsync(new InstaImageUpload(_filePath), CaptionTxt.Text);

            if (!result.Succeeded)
            {
                MessageBox.Show("Gönderi gönderilirken bir hata oluştu.", "Hata");
                return;
            }
            
            MessageBox.Show("Gönderi başarıyla gönderildi.", "Başarılı");
        }
    }

    private void SendTiming_OnChecked(object sender, RoutedEventArgs e)
    {
        TimingDate.IsEnabled = true;
    }

    private void SendTiming_OnUnchecked(object sender, RoutedEventArgs e)
    {
        TimingDate.IsEnabled = false;
    }

    private void TimingDate_OnSelectedDateChanged(object? sender, SelectionChangedEventArgs e)
    {
        _timingDate = TimingDate.SelectedDate;
    }
}