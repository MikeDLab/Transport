
// This file has been generated by the GUI designer. Do not modify.
namespace Road111
{
	public partial class TransportDialog1
	{
		private global::Gtk.Table table5;

		private global::Gtk.Entry entry1;

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

		private global::Gtk.RadioButton gas_rad;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label Param1;

		private global::Gtk.Label Param2;

		private global::Gtk.SpinButton spinbutton1;

		private global::Gtk.SpinButton spinbutton2;

		private global::Gtk.SpinButton spinbutton3;

		private global::Gtk.SpinButton spinbutton4;

		private global::Gtk.SpinButton spinbutton5;

		private global::Gtk.SpinButton spinbutton6;

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
			this.table5 = new global::Gtk.Table(((uint)(10)), ((uint)(2)), false);
			this.table5.Name = "table5";
			this.table5.RowSpacing = ((uint)(10));
			this.table5.ColumnSpacing = ((uint)(6));
			// Container child table5.Gtk.Table+TableChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '●';
			this.table5.Add(this.entry1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table5[this.entry1]));
			w2.TopAttach = ((uint)(7));
			w2.BottomAttach = ((uint)(8));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
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
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
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
			// Container child hbox3.Gtk.Box+BoxChild
			this.gas_rad = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Газ"));
			this.gas_rad.Sensitive = false;
			this.gas_rad.CanFocus = true;
			this.gas_rad.Name = "gas_rad";
			this.gas_rad.DrawIndicator = true;
			this.gas_rad.UseUnderline = true;
			this.gas_rad.Group = this.benzin_rad.Group;
			this.hbox3.Add(this.gas_rad);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.gas_rad]));
			w19.Position = 3;
			this.table5.Add(this.hbox3);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table5[this.hbox3]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Объем бака:");
			this.table5.Add(this.label1);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table5[this.label1]));
			w21.TopAttach = ((uint)(3));
			w21.BottomAttach = ((uint)(4));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Расход топлива:");
			this.table5.Add(this.label2);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table5[this.label2]));
			w22.TopAttach = ((uint)(4));
			w22.BottomAttach = ((uint)(5));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Максимальная скорость:");
			this.table5.Add(this.label3);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table5[this.label3]));
			w23.TopAttach = ((uint)(5));
			w23.BottomAttach = ((uint)(6));
			w23.XOptions = ((global::Gtk.AttachOptions)(0));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Текущая скорость:");
			this.table5.Add(this.label4);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table5[this.label4]));
			w24.TopAttach = ((uint)(6));
			w24.BottomAttach = ((uint)(7));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Марка или название:");
			this.table5.Add(this.label5);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table5[this.label5]));
			w25.TopAttach = ((uint)(7));
			w25.BottomAttach = ((uint)(8));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Грузоподъемность:");
			this.table5.Add(this.label6);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table5[this.label6]));
			w26.TopAttach = ((uint)(8));
			w26.BottomAttach = ((uint)(9));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Количество пассажиров:");
			this.table5.Add(this.label7);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table5[this.label7]));
			w27.TopAttach = ((uint)(2));
			w27.BottomAttach = ((uint)(3));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.Param1 = new global::Gtk.Label();
			this.Param1.Name = "Param1";
			this.Param1.LabelProp = global::Mono.Unix.Catalog.GetString("Тип");
			this.table5.Add(this.Param1);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table5[this.Param1]));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.Param2 = new global::Gtk.Label();
			this.Param2.Name = "Param2";
			this.Param2.LabelProp = global::Mono.Unix.Catalog.GetString("Топливо");
			this.table5.Add(this.Param2);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table5[this.Param2]));
			w29.TopAttach = ((uint)(1));
			w29.BottomAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.spinbutton1 = new global::Gtk.SpinButton(0D, 100D, 0.1D);
			this.spinbutton1.CanFocus = true;
			this.spinbutton1.Name = "spinbutton1";
			this.spinbutton1.Adjustment.PageIncrement = 10D;
			this.spinbutton1.ClimbRate = 1D;
			this.spinbutton1.Digits = ((uint)(1));
			this.spinbutton1.Numeric = true;
			this.table5.Add(this.spinbutton1);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table5[this.spinbutton1]));
			w30.TopAttach = ((uint)(3));
			w30.BottomAttach = ((uint)(4));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.spinbutton2 = new global::Gtk.SpinButton(0D, 100D, 0.1D);
			this.spinbutton2.CanFocus = true;
			this.spinbutton2.Name = "spinbutton2";
			this.spinbutton2.Adjustment.PageIncrement = 10D;
			this.spinbutton2.ClimbRate = 1D;
			this.spinbutton2.Digits = ((uint)(1));
			this.spinbutton2.Numeric = true;
			this.table5.Add(this.spinbutton2);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table5[this.spinbutton2]));
			w31.TopAttach = ((uint)(4));
			w31.BottomAttach = ((uint)(5));
			w31.LeftAttach = ((uint)(1));
			w31.RightAttach = ((uint)(2));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.spinbutton3 = new global::Gtk.SpinButton(0D, 500D, 0.1D);
			this.spinbutton3.CanFocus = true;
			this.spinbutton3.Name = "spinbutton3";
			this.spinbutton3.Adjustment.PageIncrement = 10D;
			this.spinbutton3.ClimbRate = 1D;
			this.spinbutton3.Digits = ((uint)(1));
			this.spinbutton3.Numeric = true;
			this.table5.Add(this.spinbutton3);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table5[this.spinbutton3]));
			w32.TopAttach = ((uint)(5));
			w32.BottomAttach = ((uint)(6));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.spinbutton4 = new global::Gtk.SpinButton(0D, 100D, 0.1D);
			this.spinbutton4.CanFocus = true;
			this.spinbutton4.Name = "spinbutton4";
			this.spinbutton4.Adjustment.PageIncrement = 10D;
			this.spinbutton4.ClimbRate = 1D;
			this.spinbutton4.Digits = ((uint)(1));
			this.spinbutton4.Numeric = true;
			this.table5.Add(this.spinbutton4);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table5[this.spinbutton4]));
			w33.TopAttach = ((uint)(6));
			w33.BottomAttach = ((uint)(7));
			w33.LeftAttach = ((uint)(1));
			w33.RightAttach = ((uint)(2));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.spinbutton5 = new global::Gtk.SpinButton(0D, 100D, 0.1D);
			this.spinbutton5.CanFocus = true;
			this.spinbutton5.Name = "spinbutton5";
			this.spinbutton5.Adjustment.PageIncrement = 10D;
			this.spinbutton5.ClimbRate = 1D;
			this.spinbutton5.Digits = ((uint)(1));
			this.spinbutton5.Numeric = true;
			this.table5.Add(this.spinbutton5);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table5[this.spinbutton5]));
			w34.TopAttach = ((uint)(8));
			w34.BottomAttach = ((uint)(9));
			w34.LeftAttach = ((uint)(1));
			w34.RightAttach = ((uint)(2));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table5.Gtk.Table+TableChild
			this.spinbutton6 = new global::Gtk.SpinButton(0D, 100D, 1D);
			this.spinbutton6.CanFocus = true;
			this.spinbutton6.Name = "spinbutton6";
			this.spinbutton6.Adjustment.PageIncrement = 10D;
			this.spinbutton6.ClimbRate = 1D;
			this.spinbutton6.Numeric = true;
			this.table5.Add(this.spinbutton6);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table5[this.spinbutton6]));
			w35.TopAttach = ((uint)(2));
			w35.BottomAttach = ((uint)(3));
			w35.LeftAttach = ((uint)(1));
			w35.RightAttach = ((uint)(2));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add(this.table5);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(w1[this.table5]));
			w36.Position = 0;
			// Internal child Road111.TransportDialog1.ActionArea
			global::Gtk.HButtonBox w37 = this.ActionArea;
			w37.Name = "dialog1_ActionArea";
			w37.Spacing = 10;
			w37.BorderWidth = ((uint)(5));
			w37.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w38 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w37[this.buttonCancel]));
			w38.Expand = false;
			w38.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w39 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w37[this.buttonOk]));
			w39.Position = 1;
			w39.Expand = false;
			w39.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 673;
			this.DefaultHeight = 521;
			this.Show();
			this.truck_rad.Clicked += new global::System.EventHandler(this.OnTruckRadClicked);
			this.troll_rad.Clicked += new global::System.EventHandler(this.OnTrollRadClicked);
			this.tram_rad.Clicked += new global::System.EventHandler(this.OnTramRadClicked);
			this.radiobutton21.Clicked += new global::System.EventHandler(this.OnRadiobutton21Clicked);
			this.radiobutton19.Clicked += new global::System.EventHandler(this.OnRadiobutton19Clicked);
			this.moto_rad.Clicked += new global::System.EventHandler(this.OnMotoRadClicked);
			this.loader_rad.Clicked += new global::System.EventHandler(this.OnLoaderRadClicked);
			this.horse_rad.Clicked += new global::System.EventHandler(this.OnHorseRadClicked);
			this.car_rad.Clicked += new global::System.EventHandler(this.OnCarRadClicked);
			this.bus_rad.Clicked += new global::System.EventHandler(this.OnBusRadClicked);
			this.bike_rad.Clicked += new global::System.EventHandler(this.OnBikeRadClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler(this.Cancel_Button);
			this.buttonOk.Clicked += new global::System.EventHandler(this.Ok_Button);
		}
	}
}
