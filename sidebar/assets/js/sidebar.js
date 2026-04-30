const menuBtn = document.querySelector("#menuBtn");
const exitBtn = document.querySelector("#exitBtn");
const sidePanel = document.querySelector("#sidePanel");

menuBtn.addEventListener("click", () => {
    sidePanel.classList.add("show");
    console.log("Menu opened");
});

exitBtn.addEventListener("click", () => {
    sidePanel.classList.remove("show");
    console.log("Menu closed");
});