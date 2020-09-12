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

    //if (scrollpos >= header_height) { add_class_on_scroll() }
    //else 
    if (scrollpos > lastscrollpos) { add_class_on_scroll() }
    else { remove_class_on_scroll() }
    lastscrollpos = scrollpos
})

