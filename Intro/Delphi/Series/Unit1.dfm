object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 482
  ClientWidth = 853
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
  object Label1: TLabel
    Left = 320
    Top = 160
    Width = 7
    Height = 13
    Caption = 'N'
  end
  object NTerminos: TEdit
    Left = 320
    Top = 179
    Width = 121
    Height = 21
    TabOrder = 0
  end
  object TxtResult: TEdit
    Left = 320
    Top = 240
    Width = 121
    Height = 21
    TabOrder = 1
  end
  object Button1: TButton
    Left = 80
    Top = 272
    Width = 75
    Height = 25
    Caption = 'Serie 1'
    TabOrder = 2
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 161
    Top = 272
    Width = 75
    Height = 25
    Caption = 'Serie 2'
    TabOrder = 3
    OnClick = Button2Click
  end
  object BtnSumatoria1: TButton
    Left = 242
    Top = 272
    Width = 75
    Height = 25
    Caption = 'Sumatoria 1'
    TabOrder = 4
    OnClick = BtnSumatoria1Click
  end
  object ListBoxResultado: TListBox
    Left = 712
    Top = 24
    Width = 121
    Height = 97
    ItemHeight = 13
    TabOrder = 5
  end
  object BtnCargar: TButton
    Left = 320
    Top = 328
    Width = 75
    Height = 25
    Caption = 'Cargar'
    TabOrder = 6
    OnClick = BtnCargarClick
  end
  object MainMenu1: TMainMenu
    Left = 8
    object s1: TMenuItem
      Caption = 'Ejercicios'
      object Ejercicio11: TMenuItem
        Caption = 'Ejercicio 1'
        OnClick = Ejercicio11Click
      end
      object Ejercicio21: TMenuItem
        Caption = 'Ejercicio 2'
        OnClick = Ejercicio21Click
      end
      object Ejercicio31: TMenuItem
        Caption = 'Ejercicio 3'
      end
    end
  end
end
