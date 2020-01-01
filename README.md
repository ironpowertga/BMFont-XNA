# BMFont-XNA

## How to use BMFont

1. Download [BMFont](https://www.angelcode.com/products/bmfont/)

2. Change BmFont options
   1. In options go to export options
   2. Change Bit depth : choose 32 value
   3. Change Font descriptor : choose XML
   4. Change Textures : Choose png

3. To export click on Save BitmapFont as ...

## Load BMFont

```csharp
XmlSerializer serializer = new XmlSerializer(typeof(BMFont));
FileStream stream = new FileStream(Content.RootDirectory + "/" + path + name + ".fnt", FileMode.Open);
BMFont bmFont = (BMFont)serializer.Deserialize(stream);

stream.Close();
stream.Dispose();

Font font = new Font(bmFont, content.Load<Texture2D>(bmFont.Pages[0].File.Replace(".png", "")));

```

## Draw BMFont

```csharp
//start position in the screen
Vector2 position = new Vector2(0,0);

string text = "Hello World";
Vector2 positionChar = position;
Rectangle sourceRectangle;
FontCharData data;

for (int i = 0; i < text.Length; i++)
{
    data = font.CharData(text[i]);
    
    sourceRectangle = new Rectangle(data.X, data.Y, data.Width, data.Height);
    positionChar.Y = position.Y + data.OffSetY * scale.Y;

    Draw(font.Texture, positionChar, sourceRectangle, color, rotation, origin, scale, effects;

    positionChar.X += data.AdvanceX * scale.X - data.OffSetX * scale.X;
}
```
