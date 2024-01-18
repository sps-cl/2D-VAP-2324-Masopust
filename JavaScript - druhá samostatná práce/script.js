let platno = document.getElementById("platno");
let context = platno.getContext("2d");

let stredKruhuX = 100;
let stredKruhuY = 100;

platno.onmousemove = p

function p (event) {
    stredKruhuX = event.clientX
    stredKruhuY =  event.clientY
};

function nakresli() {
    context.clearRect(0, 0, 700, 700)
    context.beginPath()
    context.arc(stredKruhuX, stredKruhuY, 50, 0, Math.PI*2)
    context.fillStyle = "blue" ;
    context.fill()

    context.fillStyle = "green" ;
    context.fillRect(200, 200, 100, 100)
    requestAnimationFrame(nakresli)
};

nakresli()

function checkRectCircleCollision(Rx,Ry,Rw,Rh, Cx,Cy,Cr) {
    let x = Cx;
    let y = Cy;
    if (x < Rx) x = Rx;
    else if (x > Rx + Rw) x = Rx + Rw;
    if (y < Ry) y = Ry;
    else if (y> Ry + Rh) y = Ry+ Rh;
    x -= Cx;
    y -= Cy;
   
    return x * x + y * y < Cr * Cr;
};