# BMFont-XNA



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
string text = "Hello World";
Vector2 positionChar = position;
Rectangle sourceRectangle;
FontCharData data;

for (int i = 0; i < text.Length; i++)
{
    data = font.CharData(text[i]);
    
    sourceRectangle = new Rectangle(data.X, data.Y, data.Width, data.Height);
    positionChar.Y = position.Y + data.OffSetY;

    Draw(font.Texture, positionChar, sourceRectangle, color, rotation, origin, scale, effects;

    positionChar.X += data.AdvanceX - data.OffSetX;
}
```