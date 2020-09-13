//iphone scroll
window.addEventListener(
    'touchmove',
    function (e) {
        e.preventDefault();
    },
    false
);

let scrollpos = window.scrollY
let lastscrollpos = 0
const header = document.querySelector("nav")
const header_height = header.offsetHeight

const add_class_on_scroll = () => header.classList.add("navbar--hidden")
const remove_class_on_scroll = () => header.classList.remove("navbar--hidden")

window.addEventListener('scroll', function () {
    scrollpos = window.scrollY;

    if (scrollpos > lastscrollpos) {
        add_class_on_scroll()
    }
    else if (scrollpos >= header_height) {  remove_class_on_scroll() }
    else { remove_class_on_scroll() }

    lastscrollpos = scrollpos
})

document.addEventListener("DOMContentLoaded", function () {
    // flag
    let flagElement = document.querySelector(".js-flag-selector");
    flagElement.addEventListener('click', function () {
        console.log('hej')
        let flagContainerElement = flagElement.querySelector(".js-flag-selector-container");
        flagContainerElement.classList.toggle("navbar__flag-selector-container--open");
    });

    //cookiebanner
    
    let cookiebanner = document.querySelector(".js-cookiebanner");

    if (-1 === document.cookie.indexOf("readcookieagreement=")) {
        setTimeout(function () {
            cookiebanner.classList.add('cookiebanner--active');
        }, 5000);
    }

    document.querySelector(".js-cookiebanner-button").addEventListener("click", function () {
        cookiebanner.classList.remove("cookiebanner--active");
        let t = new Date;

        t.setTime(t.getTime() + 31536e6);
        document.cookie = "readcookieagreement=true; expires=" + t.toGMTString() + ";"
    });

});
