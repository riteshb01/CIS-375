"use strict";

/* Author: Ritesh Bastola
file name: script.js
Added: May 4, 2025 */



// Mobile menu toggle
function toggleMenu() {
  const nav = document.getElementById("nav-links");
  nav.classList.toggle("show");
}

// Form submission message
document.addEventListener('DOMContentLoaded', function() {
  const contactForm = document.getElementById('contact-form');
  
  if (contactForm) {
    contactForm.addEventListener('submit', function(event) {
      alert('Thank you for your message! I will get back to you soon.');
    });
  }
});


// Function to update date and time
function updateDateTime() {
  const now = new Date();
  const dateString = now.toLocaleDateString();
  const timeString = now.toLocaleTimeString();
  
  document.getElementById('current-date-time').textContent = dateString + " " + timeString;
}

// Add date-time element when page loads
document.addEventListener('DOMContentLoaded', function() {
  // Create date time element
  const dateTimeElement = document.createElement('div');
  dateTimeElement.id = 'current-date-time';
  
  document.querySelector('header').appendChild(dateTimeElement);
  
  // Initialize and update every second
  updateDateTime();
  setInterval(updateDateTime, 1000);
});


//Dark mode instead of SwapImage 

// named function
function toggleDarkMode() {
  document.body.classList.toggle('dark-mode');
}

// event listener
document.addEventListener('DOMContentLoaded', () => {
  const btn = document.getElementById('darkModeBtn');
  btn.addEventListener('click', toggleDarkMode);
});
