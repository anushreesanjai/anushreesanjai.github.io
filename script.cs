document.querySelectorAll('.project-link').forEach(link => {
    link.addEventListener('click', event => {
        event.preventDefault();
        const targetUrl = event.currentTarget.getAttribute('href');
        setTimeout(() => {
            window.location.href = targetUrl;
        }, 200); // Delay for transition effect
    });
});

document.querySelectorAll('.project-item').forEach(item => {
    item.addEventListener('mouseover', () => {
        item.classList.add('hover');
    });
    item.addEventListener('mouseout', () => {
        item.classList.remove('hover');
    });
});