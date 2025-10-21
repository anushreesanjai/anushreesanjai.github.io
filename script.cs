// 🌙 Dark mode toggle
const themeToggle = document.getElementById("themeToggle");
themeToggle.addEventListener("click", () => {
  document.body.classList.toggle("dark");
  themeToggle.textContent = document.body.classList.contains("dark") ? "☀️" : "🌙";
});

// 📱 Mobile menu
const menuToggle = document.getElementById("menuToggle");
const nav = document.getElementById("nav");
menuToggle.addEventListener("click", () => {
  nav.classList.toggle("active");
});

// 📩 Contact form
document.getElementById("contactForm").addEventListener("submit", (e) => {
  e.preventDefault();
  const name = document.getElementById("name").value.trim();
  const email = document.getElementById("email").value.trim();
  const message = document.getElementById("message").value.trim();
  const msg = document.getElementById("formMsg");

  if (!name || !email || !message) {
    msg.textContent = "Please fill all fields ❗";
    msg.style.color = "tomato";
    return;
  }

  msg.textContent = "Message sent successfully ✔️";
  msg.style.color = "green";
  e.target.reset();
});

// 💫 Scroll reveal animation
const elements = document.querySelectorAll(".card, .about-text, .about-image");
const observer = new IntersectionObserver((entries) => {
  entries.forEach(entry => {
    if (entry.isIntersecting) {
      entry.target.classList.add("visible");
    }
  });
}, { threshold: 0.2 });

elements.forEach(el => observer.observe(el));

