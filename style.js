function GetAllResistance(){
  let r1 = prompt('Enter first resistance', '')
  let r2 = prompt('Enter second resistance', '');
  let allr=(parseInt(r1)*parseInt(r2))/(parseInt(r1)+parseInt(r2));
  alert('All resistance is ' + allr)
}

function GetVolumeParallelepiped(){
  let a = prompt('Enter lenght','');
  let b = prompt('Enter width', '');
  let c = prompt('Enter height', '');
  let V = parseInt(a)*parseInt(b)*parseInt(c);
  alert('The volume of the parallelepiped is ' + V);
}

function GetPercentage(){
  let p = prompt('Enter deposit amount ', '');
  let i = prompt('Enter deposit rate ', '');
  let t = prompt('Уnter the number of days of holding the deposit ', '');
  let s = ((parseFloat(p) * parseFloat(i) * parseFloat(t)) / 365) / 100;
  alert('Your percentage from the deposit is ' + s);
}