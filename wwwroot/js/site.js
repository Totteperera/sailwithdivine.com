// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


let scrollpos = window.scrollY
let lastscrollpos = 0
const header = document.querySelector("nav")
const header_height = header.offsetHeight

const add_class_on_scroll = () => header.classList.add("navbar--hidden")
const remove_class_on_scroll = () => header.classList.remove("navbar--hidden")

window.addEventListener('scroll', function () {
    scrollpos = window.scrollY;

    if (scrollpos > lastscrollpos) { add_class_on_scroll() }
    else { remove_class_on_scroll() }
    lastscrollpos = scrollpos
})