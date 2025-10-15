function openProject(num) {
  // Replace these with your actual project URLs
  const urls = {
    1: "project1.html",
    2: "project2.html",
    3: "project3.html"
  };
  window.location.href = urls[num] || "#";
}
