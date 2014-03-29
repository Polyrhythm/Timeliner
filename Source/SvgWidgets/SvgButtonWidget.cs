﻿using System;
using Svg;

namespace Timeliner
{
	/// <summary>
	/// Parses a svg document and provides events.
	/// </summary>
	public class SvgButtonWidget: SvgWidget
	{
		private SvgText FLabel;
        public string Label
        {
            get { return FLabel.Text;}
            set { FLabel.Text = value;}
        }
        
		public Action OnButtonPressed;		
		
		public SvgButtonWidget(string label): base()
		{
            Background.MouseOver += Background_MouseOver;
			Background.MouseOut += Background_MouseOut;
			Background.MouseDown += Background_MouseDown;
            Background.CustomAttributes["class"] = "menu";
			
			FLabel = new SvgText(label);
			FLabel.FontSize = 12;
			FLabel.X = 2;
			FLabel.Y = FLabel.FontSize + 2;
            FLabel.CustomAttributes["class"] = "menufont";
            
            this.Children.Add(FLabel);
		}
		
		public SvgButtonWidget(float width, float height, string label): this(label)
		{
			Width = width;
			Height = height;
		}
        
        void Background_MouseOver(object sender, EventArgs e)
		{
		}
		
		void Background_MouseOut(object sender, EventArgs e)
		{
		}
	
		void Background_MouseDown(object sender, EventArgs e)
		{
			OnButtonPressed.Invoke();
		}
	}
}
