﻿window.addEventListener("load", () => {
    const canvas = document.querySelector("#canvas");

    const ctx = canvas.getContext("2d");

    canvas.height = window.innerHeight;
    canvas.width = window.innerWidth;


    let painting = false;

    function startPosition() {
        painting = true;
    }
    function stopPosition(){
        painting = false;
    }
    function draw(e) {
        if (!painting) return;
        ctx.lineWidth = 10;
        ctx.lineCap = "round";
        ctx.lineTo(e.clientX, e.ClientY);
        ctx.stroke();
    }

    canvas.addEventListener("mousedown", startPosition);
    canvas.addEventListener("mouseup", startPosition);
    canvas.addEventListener("mousemove", draw);








});
