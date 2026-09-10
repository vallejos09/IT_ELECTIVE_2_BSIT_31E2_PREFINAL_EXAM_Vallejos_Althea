document.addEventListener("click", function (event) {
    var btn = event.target.closest(".reveal-btn");
    if (!btn) return;

    var target = document.getElementById(btn.dataset.target);
    if (!target) return;

    var isOpen = target.classList.toggle("open");
    btn.textContent = isOpen ? "Hide reasoning" : "Show reasoning";
});
