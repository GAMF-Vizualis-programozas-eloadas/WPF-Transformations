using System.Windows;
using System.Windows.Media;

namespace WPFTransformations
{
	
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			btGomb.RenderTransformOrigin = new Point(0.5, 0.5);
		}
		private void btTranslateTransform_Click(object sender, RoutedEventArgs e)
		{
			TranslateTransform tt =
				new TranslateTransform(100, 50);
			btGomb.RenderTransform = tt;
		}
		private void btRotateTransform_Click(object sender, RoutedEventArgs e)
		{
			RotateTransform rt=new RotateTransform(30,0,0);
			btGomb.RenderTransform = rt;
		}
		private void btScaleTransform_Click(object sender, RoutedEventArgs e)
		{
			ScaleTransform sc = new ScaleTransform(0.5, 2);
			btGomb.RenderTransform = sc;
		}
		private void btSkewTransform_Click(object sender, RoutedEventArgs e)
		{
			// Az első szögérték (AngleX) megadja a nyújtás szögmértékét az y tengelyhez mérve órajárással szemben mérve.
			// A második szögérték (AngleY) megadja a nyújtás szögmértékét az x tengelyhez mérve órajárással szemben mérve.
			SkewTransform sk = new SkewTransform(0, 45,0,0);
			btGomb.RenderTransform = sk;
		}
		private void btMatrixTransform_Click(object sender, RoutedEventArgs e)
		{
			// m11,m12,OffsetX,OffsetY
			// X' = X*M11 + Y*M21 + OfX
			// Y' = X*M12 + Y*M22 + OfY
			MatrixTransform mt =
				new MatrixTransform(0.7, -0.7, 0.7, 0.7, 0, 0);
			btGomb.RenderTransform = mt;
		}
		private void btEredeti_Click(object sender, RoutedEventArgs e)
		{
			// m11,m12,OffsetX,OffsetY
			// X' = X*M11 + Y*M21 + OfX
			// Y' = X*M12 + Y*M22 + OfY
			MatrixTransform mt = new MatrixTransform(1, 0, 0, 1, 0, 0);
			btGomb.RenderTransform = mt;
		}
		private void btTükrözF_Click(object sender, RoutedEventArgs e)
		{
			MatrixTransform mt = new MatrixTransform(-1, 0, 0, 1, 0, 0);
			btGomb.RenderTransform = mt;
		}
		private void btTükrözV_Click(object sender, RoutedEventArgs e)
		{
			MatrixTransform mt = new MatrixTransform(1, 0, 0, -1, 0, 0);
			btGomb.RenderTransform = mt;
		}
	}
}
