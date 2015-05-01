window = { 
name: 'MyGame', 
width: 800, 
height: 600,

form.MouseClick(

function (sender, e) {

System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
Console.WriteLine('{0} pressed!', e.Button);
Console.WriteLine('{0} pressed!', e.Clicks);
Console.WriteLine('{0} pressed!', e.X);
Console.WriteLine('{0} pressed!', e.Y);
});

};
