object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 299
  ClientWidth = 635
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
  object TxtNumero: TEdit
    Left = 112
    Top = 88
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'Numero'
  end
  object TxtResultado: TEdit
    Left = 112
    Top = 128
    Width = 121
    Height = 21
    TabOrder = 1
    Text = 'Resultado'
  end
  object Button1: TButton
    Left = 239
    Top = 102
    Width = 75
    Height = 25
    Caption = 'Registrar N'
    TabOrder = 2
    OnClick = Button1Click
  end
  object MainMenu1: TMainMenu
    Left = 8
    object Er1: TMenuItem
      Caption = 'Ejercicios'
      object Ejercicios1: TMenuItem
        Caption = 'Ejercicio 9'
        OnClick = Ejercicios1Click
      end
      object Ejercicio131: TMenuItem
        Caption = 'Ejercicio 13'
        OnClick = Ejercicio131Click
      end
      object Ordenar1: TMenuItem
        Caption = 'Ejercicio 27'
        OnClick = Ordenar1Click
      end
      object Ejercicio31: TMenuItem
        Caption = 'Ejercicio 3'
        OnClick = Ejercicio31Click
      end
      object Ejercicio331: TMenuItem
        Caption = 'Ejercicio 33'
        OnClick = Ejercicio331Click
      end
      object Ejercicio261: TMenuItem
        Caption = 'Ejercicio 26'
        OnClick = Ejercicio261Click
      end
      object Ejercicio51: TMenuItem
        Caption = 'Ejercicio 5'
        OnClick = Ejercicio51Click
      end
    end
  end
end
