
// This file has been generated by the GUI designer. Do not modify.
namespace Road111
{
	public partial class TransportDialog1
	{
		private global::Gtk.Table table5;

		private global::Gtk.Entry entry9;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Table table1;

		private global::Gtk.RadioButton bike_rad;

		private global::Gtk.RadioButton bus_rad;

		private global::Gtk.RadioButton car_rad;

		private global::Gtk.RadioButton horse_rad;

		private global::Gtk.RadioButton loader_rad;

		private global::Gtk.RadioButton moto_rad;

		private global::Gtk.RadioButton radiobutton19;

		private global::Gtk.RadioButton radiobutton21;

		private global::Gtk.RadioButton tram_rad;

		private global::Gtk.RadioButton troll_rad;

		private global::Gtk.RadioButton truck_rad;

		private global::Gtk.HBox hbox3;

		private global::Gtk.RadioButton benzin_rad;

		private global::Gtk.RadioButton dizel_rad;

		private global::Gtk.RadioButton electro_rad;

		private global::Gtk.Label Param1;

		private global::Gtk.Label Param2;

		private global::Gtk.Label Param3;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Road111.TransportDialog1
			this.Name = "Road111.TransportDialog1";
			this.WindowPosition = ((global::Gtk.WindowPosition)(2));
			this.Resizable = false;
			// Internal child Road111.TransportDialog1.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(3));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table5 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
			this.table5.Name = "table5";
			this.table5.RowSpacing = ((uint)(10));
			this.table5.ColumnSpacing = ((uint)(6));
			// Container child table5.Gtk.Table+TableChild
			this.entry9 = new global::Gtk.Entry();
			this.entry9.Sensitive = false;
			this.entry9.CanFocus = true;
			this.entry9.Name = "entry9";
			this.entry9.Text = global::Mono.Unix.Catalog.GetString("param 3 value");
			this.entry9.IsEditable = true;
			this.entry9.InvisibleChar = '●';
			this.table5.Add(this.entry9);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table5[this.entry9]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(4)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.bike_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Велосипед"));
			this.bike_rad.CanFocus = true;
			this.bike_rad.Name = "bike_rad";
			this.bike_rad.DrawIndicator = true;
			this.bike_rad.UseUnderline = true;
			this.bike_rad.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.table1.Add(this.bike_rad);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.bike_rad]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.bus_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Автобус"));
			this.bus_rad.CanFocus = true;
			this.bus_rad.Name = "bus_rad";
			this.bus_rad.DrawIndicator = true;
			this.bus_rad.UseUnderline = true;
			this.bus_rad.Group = this.bike_rad.Group;
			this.table1.Add(this.bus_rad);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.bus_rad]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.car_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Автомобиль"));
			this.car_rad.CanFocus = true;
			this.car_rad.Name = "car_rad";
			this.car_rad.DrawIndicator = true;
			this.car_rad.UseUnderline = true;
			this.car_rad.Group = this.bike_rad.Group;
			this.table1.Add(this.car_rad);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.car_rad]));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.horse_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Гужевая повозка"));
			this.horse_rad.CanFocus = true;
			this.horse_rad.Name = "horse_rad";
			this.horse_rad.DrawIndicator = true;
			this.horse_rad.UseUnderline = true;
			this.horse_rad.Group = this.bike_rad.Group;
			this.table1.Add(this.horse_rad);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.horse_rad]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.loader_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Погрузчик"));
			this.loader_rad.CanFocus = true;
			this.loader_rad.Name = "loader_rad";
			this.loader_rad.DrawIndicator = true;
			this.loader_rad.UseUnderline = true;
			this.loader_rad.Group = this.bike_rad.Group;
			this.table1.Add(this.loader_rad);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.loader_rad]));
			w7.LeftAttach = ((uint)(2));
			w7.RightAttach = ((uint)(3));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.moto_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Мотоцикл"));
			this.moto_rad.CanFocus = true;
			this.moto_rad.Name = "moto_rad";
			this.moto_rad.DrawIndicator = true;
			this.moto_rad.UseUnderline = true;
			this.moto_rad.Group = this.bike_rad.Group;
			this.table1.Add(this.moto_rad);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.moto_rad]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobutton19 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Самокат"));
			this.radiobutton19.CanFocus = true;
			this.radiobutton19.Name = "radiobutton19";
			this.radiobutton19.DrawIndicator = true;
			this.radiobutton19.UseUnderline = true;
			this.radiobutton19.Group = this.bike_rad.Group;
			this.table1.Add(this.radiobutton19);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobutton19]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.radiobutton21 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Танк"));
			this.radiobutton21.CanFocus = true;
			this.radiobutton21.Name = "radiobutton21";
			this.radiobutton21.DrawIndicator = true;
			this.radiobutton21.UseUnderline = true;
			this.radiobutton21.Group = this.bike_rad.Group;
			this.table1.Add(this.radiobutton21);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.radiobutton21]));
			w10.TopAttach = ((uint)(3));
			w10.BottomAttach = ((uint)(4));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.tram_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Трамвай"));
			this.tram_rad.CanFocus = true;
			this.tram_rad.Name = "tram_rad";
			this.tram_rad.DrawIndicator = true;
			this.tram_rad.UseUnderline = true;
			this.tram_rad.Group = this.bike_rad.Group;
			this.table1.Add(this.tram_rad);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.tram_rad]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.troll_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Тролейбус"));
			this.troll_rad.CanFocus = true;
			this.troll_rad.Name = "troll_rad";
			this.troll_rad.DrawIndicator = true;
			this.troll_rad.UseUnderline = true;
			this.troll_rad.Group = this.bike_rad.Group;
			this.table1.Add(this.troll_rad);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.troll_rad]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.truck_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Грузовик"));
			this.truck_rad.CanFocus = true;
			this.truck_rad.Name = "truck_rad";
			this.truck_rad.DrawIndicator = true;
			this.truck_rad.UseUnderline = true;
			this.truck_rad.Group = this.bike_rad.Group;
			this.table1.Add(this.truck_rad);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.truck_rad]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w14.Position = 0;
			this.table5.Add(this.hbox1);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table5[this.hbox1]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.benzin_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Бензин"));
			this.benzin_rad.Sensitive = false;
			this.benzin_rad.CanFocus = true;
			this.benzin_rad.Name = "benzin_rad";
			this.benzin_rad.DrawIndicator = true;
			this.benzin_rad.UseUnderline = true;
			this.benzin_rad.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.hbox3.Add(this.benzin_rad);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.benzin_rad]));
			w16.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.dizel_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Дизель"));
			this.dizel_rad.Sensitive = false;
			this.dizel_rad.CanFocus = true;
			this.dizel_rad.Name = "dizel_rad";
			this.dizel_rad.DrawIndicator = true;
			this.dizel_rad.UseUnderline = true;
			this.dizel_rad.Group = this.benzin_rad.Group;
			this.hbox3.Add(this.dizel_rad);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.dizel_rad]));
			w17.Position = 1;
			// Container child hbox3.Gtk.Box+BoxChild
			this.electro_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Электричество"));
			this.electro_rad.Sensitive = false;
			this.electro_rad.CanFocus = true;
			this.electro_rad.Name = "electro_rad";
			this.electro_rad.DrawIndicator = true;
			this.electro_rad.UseUnderline = true;
			this.electro_rad.Group = this.benzin_rad.Group;
			this.hbox3.Add(this.electro_rad);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.electro_rad]));
			w18.Position = 2;
			this.table5.Add(this.hbox3);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table5[this.hbox3]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.Param1 = new global::Gtk.Label();
			this.Param1.Name = "Param1";
			this.Param1.LabelProp = global::Mono.Unix.Catalog.GetString("Тип");
			this.table5.Add(this.Param1);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table5[this.Param1]));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.Param2 = new global::Gtk.Label();
			this.Param2.Name = "Param2";
			this.Param2.LabelProp = global::Mono.Unix.Catalog.GetString("Топливо");
			this.table5.Add(this.Param2);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table5[this.Param2]));
			w21.TopAttach = ((uint)(1));
			w21.BottomAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.Param3 = new global::Gtk.Label();
			this.Param3.Name = "Param3";
			this.Param3.Xalign = 0F;
			this.Param3.LabelProp = global::Mono.Unix.Catalog.GetString("Скорость");
			this.table5.Add(this.Param3);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table5[this.Param3]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add(this.table5);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(w1[this.table5]));
			w23.Position = 0;
			// Internal child Road111.TransportDialog1.ActionArea
			global::Gtk.HButtonBox w24 = this.ActionArea;
			w24.Name = "dialog1_ActionArea";
			w24.Spacing = 10;
			w24.BorderWidth = ((uint)(5));
			w24.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w25 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w24[this.buttonCancel]));
			w25.Expand = false;
			w25.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w26 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w24[this.buttonOk]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 673;
			this.DefaultHeight = 521;
			this.Show();
			this.buttonCancel.Clicked += new global::System.EventHandler(this.Cancel_Button);
			this.buttonOk.Clicked += new global::System.EventHandler(this.Ok_Button);
		}
	}
}
