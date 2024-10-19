document.addEventListener("DOMContentLoaded", function () {
    var SliderImg = document.querySelectorAll(".slider_img img");
    var SliderDot = document.querySelectorAll(".slider_dot span");
    var SliderLength = SliderImg.length;
    var currenIndex = 0;

    function ImgNext(index) {
        SliderImg.forEach(img => img.classList.remove("display_block"));
        SliderImg[index].classList.add("display_block");
        SliderDot.forEach(dot => dot.classList.remove("slider-span"));
        SliderDot[index].classList.add("slider-span");
        currenIndex = index;
    }

    function NextImgDot() {
        ImgNext((currenIndex + 1) % SliderLength);
    }

    SliderDot.forEach(function (dot, index) {
        dot.addEventListener("click", function () {
            ImgNext(index);
        });
    });

    setInterval(NextImgDot, 5000);
});