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
  object Edit1: TEdit
    Left = 104
    Top = 80
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'Edit1'
  end
  object Edit2: TEdit
    Left = 344
    Top = 64
    Width = 121
    Height = 65
    TabOrder = 1
    Text = 'Edit2'
  end
  object MainMenu1: TMainMenu
    Left = 8
    object Eliminarrepetidos1: TMenuItem
      Caption = 'Ejercicios'
      object Eliminarrepetidos2: TMenuItem
        Caption = 'Eliminar repetidos'
        OnClick = Eliminarrepetidos2Click
      end
      object Ordenardigitos1: TMenuItem
        Caption = 'Ordenar digitos'
        OnClick = Ordenardigitos1Click
      end
    end
  end
end
