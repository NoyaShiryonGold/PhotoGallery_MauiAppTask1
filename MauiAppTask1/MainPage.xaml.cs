using static System.Net.Mime.MediaTypeNames;


namespace MauiAppTask1
{
    public partial class MainPage : ContentPage
    {
        Button prevBtn, nextBtn;
        Microsoft.Maui.Controls.Image imageHolder;
        int num =1;
        string[] images = ["a1.jpg", "a2.jpg", "a3.jpg", "a4.jpg", "a5.jpg"];
        public MainPage()
        {
            InitializeComponent();
            LoadView();
            nextBtn.IsEnabled = true;
            prevBtn.IsEnabled = false;
        }

        private void LoadView()
        {
            #region Labels
            Label header = new Label();
            header.Text = "Image APP";
            header.Style = (Style)Microsoft.Maui.Controls.Application.Current.Resources["Headline"];
            header.FontFamily = "Pacifico";
            SemanticProperties.SetHeadingLevel(header, SemanticHeadingLevel.Level2);
            Label description = new Label();
            description.Text = "Click the arrows to change image";
            description.Style = (Style)Microsoft.Maui.Controls.Application.Current.Resources["SubHeadline"];
            description.FontFamily = "EduAU";
            SemanticProperties.SetHeadingLevel(description, SemanticHeadingLevel.Level4);            
            #endregion
            #region Buttons
            prevBtn = new Button();
            prevBtn.Text = "\uf182";
            prevBtn.Style = (Style)Microsoft.Maui.Controls.Application.Current.Resources["IconButton"];
            SemanticProperties.SetHint(prevBtn, "previous image");
            prevBtn.Clicked += OnArrowClicked;
            nextBtn = new Button();
            nextBtn.Text = "\uf181;";
            nextBtn.Style = (Style)Microsoft.Maui.Controls.Application.Current.Resources["IconButton"];
            SemanticProperties.SetHint(nextBtn, "next image");
            nextBtn.Clicked += OnArrowClicked;
            #endregion
            #region Image&Border
            imageHolder = new Microsoft.Maui.Controls.Image();
            imageHolder.Source = ImageSource.FromFile("logo.jpg");
            imageHolder.HeightRequest = 250;
            imageHolder.Aspect = Aspect.AspectFit;
            SemanticProperties.SetDescription(imageHolder, "image view");
            Border border=new Border();
            border.Stroke = Microsoft.Maui.Controls.Brush.CadetBlue;
            border.StrokeThickness = 10;
            border.HorizontalOptions = LayoutOptions.Center;
            border.Content=imageHolder;
            #endregion
            #region Layout
            MainLayout.Children.Add(description);
            MainLayout.Children.Add(header);
            MainLayout.Children.Add(prevBtn);
            MainLayout.Children.Add(border);
            MainLayout.Children.Add(nextBtn);
            #endregion
        }


        private void OnArrowClicked(object sender, EventArgs e)
        {
            if (sender==prevBtn)
            {               
                if (num > 0)
                {
                    num--;
                    imageHolder.Source = images[num];
                }
            }
            else
            {                
                if (num <images.Length-1)
                {
                    num++;
                    imageHolder.Source = images[num];
                }
            }
            prevBtn.IsEnabled = num > 0; 
            nextBtn.IsEnabled = num < images.Length-1;
            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
