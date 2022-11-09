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

function GetBuySumm(){
  let cn = prompt('Enter count of notebooks ', '');
  let pn = prompt('Enter price of one notebook ', '');
  let cp = prompt('Enter count of pencils ', '');
  let pc = prompt('Enter price of one pencil ', '');
  let sum = (parseFloat(cn)*parseFloat(pn))+(parseFloat(cp)*parseFloat(pc));
  alert('The purchase amount is equal to ' + sum);
}
/* Не доделано :)
function GetTripPrice(){
  let r = prompt('Enter range ','');
  let r100 = prompt('Enter cost on 100 km', '');
  let p = prompt('Enter price', '');
  let tp = (parseInt(r) * (parseInt(r100) / 100) * parseInt(p)) * 2;
  alert('The price of the car trip is ' + tp);
}
GetTripPrice();
*/