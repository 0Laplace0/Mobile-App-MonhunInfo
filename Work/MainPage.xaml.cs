namespace Work
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped_GS(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GreatSword());
        }

        private void TapGestureRecognizer_Tapped_LS(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LongSword());
        }

        private void TapGestureRecognizer_Tapped_SS(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SwordandShield());
        }

        private void TapGestureRecognizer_Tapped_DB(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DualBlades());
        }

        private void TapGestureRecognizer_Tapped_HM(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hammer());
        }

        private void TapGestureRecognizer_Tapped_HH(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HuntingHorn());
        }

        private void TapGestureRecognizer_Tapped_LA(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Lance());
        }

        private void TapGestureRecognizer_Tapped_GL(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Gunlance());
        }

        private void TapGestureRecognizer_Tapped_SA(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SwitchAxe());
        }

        private void TapGestureRecognizer_Tapped_CB(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChargeBlade());
        }

        private void TapGestureRecognizer_Tapped_LB(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LightBowgun());
        }

        private void TapGestureRecognizer_Tapped_HB(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HeavyBowgun());
        }

        private void TapGestureRecognizer_Tapped_BW(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bow());
        }

        private void TapGestureRecognizer_Tapped_IG(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsectGlaive());
        }

        private void TapGestureRecognizer_Tapped_IS(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Insect());
        }

    }

}
