object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 450
  ClientWidth = 824
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object TxtCad: TEdit
    Left = 176
    Top = 128
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'TxtCad'
  end
  object TxtResultado: TEdit
    Left = 176
    Top = 184
    Width = 305
    Height = 73
    TabOrder = 1
    Text = 'TxtResultado'
  end
  object Edit1: TEdit
    Left = 176
    Top = 157
    Width = 121
    Height = 21
    TabOrder = 2
    Text = 'Edit1'
  end
  object BtnRegistrar: TButton
    Left = 303
    Top = 126
    Width = 75
    Height = 25
    Caption = 'Registrar'
    TabOrder = 3
    OnClick = BtnRegistrarClick
  end
  object Button1: TButton
    Left = 384
    Top = 126
    Width = 121
    Height = 25
    Caption = 'Mostrar longitud'
    TabOrder = 4
    OnClick = Button1Click
  end
  object MainMenu1: TMainMenu
    object Ejercicios1: TMenuItem
      Caption = 'Ejercicios'
      object Ejercicio121: TMenuItem
        Caption = 'Ejercicio 12'
        OnClick = Ejercicio121Click
      end
      object Ejercicio12V21: TMenuItem
        Caption = 'Ejercicio 12 V2'
        OnClick = Ejercicio12V21Click
      end
      object Ejercicio91: TMenuItem
        Caption = 'Ejercicio 9'
        OnClick = Ejercicio91Click
      end
      object Ejercicio191: TMenuItem
        Caption = 'Ejercicio 19'
        OnClick = Ejercicio191Click
      end
      object Ejercicio201: TMenuItem
        Caption = 'Ejercicio 20'
        OnClick = Ejercicio201Click
      end
      object Ejercicio141: TMenuItem
        Caption = 'Ejercicio 14'
        OnClick = Ejercicio141Click
      end
      object Ejercicio161: TMenuItem
        Caption = 'Ejercicio 16'
        OnClick = Ejercicio161Click
      end
      object Ejercicio171: TMenuItem
        Caption = 'Ejercicio 17'
        OnClick = Ejercicio171Click
      end
    end
  end
end
