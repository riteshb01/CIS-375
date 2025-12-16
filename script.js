"use strict";

/* Author: Ritesh Bastola
file name: script.js
Added: May 4, 2025 */

// ===== MOBILE MENU TOGGLE =====
function toggleMenu() {
  const nav = document.getElementById("nav-links");
  nav.classList.toggle("show");
}

// ===== DARK MODE TOGGLE WITH LOCALSTORAGE =====
function toggleDarkMode() {
  document.body.classList.toggle('dark-mode');
  
  // Store preference in localStorage
  const isDarkMode = document.body.classList.contains('dark-mode');
  localStorage.setItem('darkMode', isDarkMode ? 'enabled' : 'disabled');
}

// ===== SCROLL TO TOP BUTTON =====
function createScrollToTopButton() {
  const button = document.createElement('button');
  button.id = 'scrollToTop';
  button.innerHTML = '↑';
  button.setAttribute('aria-label', 'Scroll to top');
  button.setAttribute('title', 'Back to top');
  document.body.appendChild(button);
  
  // Show/hide button based on scroll position
  window.addEventListener('scroll', () => {
    if (window.pageYOffset > 300) {
      button.classList.add('show');
    } else {
      button.classList.remove('show');
    }
  });
  
  // Scroll to top when clicked
  button.addEventListener('click', () => {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    });
  });
}

// ===== FADE IN ON SCROLL (INTERSECTION OBSERVER) =====
function initScrollAnimations() {
  const observerOptions = {
    threshold: 0.1,
    rootMargin: '0px 0px -50px 0px'
  };
  
  const observer = new IntersectionObserver((entries) => {
    entries.forEach(entry => {
      if (entry.isIntersecting) {
        entry.target.classList.add('visible');
        observer.unobserve(entry.target);
      }
    });
  }, observerOptions);
  
  // Observe all sections
  document.querySelectorAll('section').forEach(section => {
    section.classList.add('fade-in-on-scroll');
    observer.observe(section);
  });
}

// ===== SKIP TO CONTENT LINK =====
function addSkipToContent() {
  const skipLink = document.createElement('a');
  skipLink.href = '#main';
  skipLink.textContent = 'Skip to main content';
  skipLink.className = 'skip-to-content';
  skipLink.style.cssText = `
    position: absolute;
    top: -40px;
    left: 0;
    background: var(--primary-color);
    color: white;
    padding: 8px 16px;
    text-decoration: none;
    border-radius: 0 0 4px 0;
    z-index: 1000;
    transition: top 0.3s;
  `;
  
  skipLink.addEventListener('focus', () => {
    skipLink.style.top = '0';
  });
  
  skipLink.addEventListener('blur', () => {
    skipLink.style.top = '-40px';
  });
  
  document.body.insertBefore(skipLink, document.body.firstChild);
  
  // Add id to main if it doesn't exist
  const main = document.querySelector('main');
  if (main && !main.id) {
    main.id = 'main';
  }
}

// ===== FORM VALIDATION ENHANCEMENT =====
function enhanceFormValidation() {
  const contactForm = document.getElementById('contact-form');
  
  if (contactForm) {
    const inputs = contactForm.querySelectorAll('input, textarea');
    
    inputs.forEach(input => {
      input.addEventListener('blur', function() {
        validateField(this);
      });
      
      input.addEventListener('input', function() {
        if (this.classList.contains('error')) {
          validateField(this);
        }
      });
    });
    
    contactForm.addEventListener('submit', function(event) {
      let isValid = true;
      
      inputs.forEach(input => {
        if (!validateField(input)) {
          isValid = false;
        }
      });
      
      if (isValid) {
        alert('Thank you for your message! I will get back to you soon.');
      } else {
        event.preventDefault();
        alert('Please correct the errors in the form.');
      }
    });
  }
}

function validateField(field) {
  const errorClass = 'error';
  const successClass = 'success';
  
  // Remove previous states
  field.classList.remove(errorClass, successClass);
  
  // Check if required field is empty
  if (field.hasAttribute('required') && !field.value.trim()) {
    field.classList.add(errorClass);
    field.style.borderColor = '#e74c3c';
    return false;
  }
  
  // Validate email
  if (field.type === 'email') {
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!emailRegex.test(field.value)) {
      field.classList.add(errorClass);
      field.style.borderColor = '#e74c3c';
      return false;
    }
  }
  
  // Validate phone
  if (field.type === 'tel' && field.value) {
    const phoneRegex = /^\d{3}-\d{3}-\d{4}$/;
    if (!phoneRegex.test(field.value)) {
      field.classList.add(errorClass);
      field.style.borderColor = '#e74c3c';
      return false;
    }
  }
  
  // Field is valid
  field.classList.add(successClass);
  field.style.borderColor = '#2ecc71';
  return true;
}


// ===== DATE AND TIME UPDATE =====
function updateDateTime() {
  const now = new Date();
  const dateString = now.toLocaleDateString();
  const timeString = now.toLocaleTimeString();
  
  const element = document.getElementById('current-date-time');
  if (element) {
    element.textContent = dateString + " " + timeString;
  }
}

// ===== INITIALIZE ALL FEATURES ON PAGE LOAD =====
document.addEventListener('DOMContentLoaded', function() {
  // Load dark mode preference
  const darkModePreference = localStorage.getItem('darkMode');
  if (darkModePreference === 'enabled') {
    document.body.classList.add('dark-mode');
  }
  
  // Setup dark mode button
  const btn = document.getElementById('darkModeBtn');
  if (btn) {
    btn.addEventListener('click', toggleDarkMode);
  }
  
  // Create and setup date-time element
  const dateTimeElement = document.createElement('div');
  dateTimeElement.id = 'current-date-time';
  dateTimeElement.style.cssText = `
    color: white;
    font-size: 0.9rem;
    margin-top: 10px;
    opacity: 0.9;
  `;
  
  const header = document.querySelector('header');
  if (header) {
    header.appendChild(dateTimeElement);
    updateDateTime();
    setInterval(updateDateTime, 1000);
  }
  
  // Initialize scroll to top button
  createScrollToTopButton();
  
  // Initialize scroll animations
  initScrollAnimations();
  
  // Add skip to content link for accessibility
  addSkipToContent();
  
  // Enhance form validation
  enhanceFormValidation();
  
  // Add ripple effect to buttons
  addRippleEffectToButtons();
  
  // Lazy load images
  lazyLoadImages();
  
  // Add keyboard navigation support
  enhanceKeyboardNavigation();
});

// ===== RIPPLE EFFECT FOR BUTTONS =====
function addRippleEffectToButtons() {
  const buttons = document.querySelectorAll('button, .submit-btn, .btn-primary');
  buttons.forEach(button => {
    button.classList.add('ripple-effect');
  });
}

// ===== LAZY LOAD IMAGES =====
function lazyLoadImages() {
  const images = document.querySelectorAll('img[loading="lazy"]');
  
  if ('IntersectionObserver' in window) {
    const imageObserver = new IntersectionObserver((entries, observer) => {
      entries.forEach(entry => {
        if (entry.isIntersecting) {
          const img = entry.target;
          img.src = img.src; // Trigger loading
          img.classList.add('loaded');
          observer.unobserve(img);
        }
      });
    });
    
    images.forEach(img => imageObserver.observe(img));
  }
}

// ===== KEYBOARD NAVIGATION ENHANCEMENT =====
function enhanceKeyboardNavigation() {
  // Add visible focus indicator
  document.addEventListener('keydown', (e) => {
    if (e.key === 'Tab') {
      document.body.classList.add('keyboard-nav');
    }
  });
  
  document.addEventListener('mousedown', () => {
    document.body.classList.remove('keyboard-nav');
  });
  
  // Allow Enter/Space to activate hamburger menu
  const hamburger = document.querySelector('.hamburger');
  if (hamburger) {
    hamburger.setAttribute('tabindex', '0');
    hamburger.setAttribute('role', 'button');
    
    hamburger.addEventListener('keydown', (e) => {
      if (e.key === 'Enter' || e.key === ' ') {
        e.preventDefault();
        toggleMenu();
      }
    });
  }
}

// ===== CLOSE MOBILE MENU WHEN CLICKING OUTSIDE =====
document.addEventListener('click', function(event) {
  const nav = document.getElementById('nav-links');
  const hamburger = document.querySelector('.hamburger');
  
  if (nav && hamburger) {
    if (nav.classList.contains('show') && 
        !nav.contains(event.target) && 
        !hamburger.contains(event.target)) {
      nav.classList.remove('show');
    }
  }
});

// ===== CLOSE MOBILE MENU ON ESC KEY =====
document.addEventListener('keydown', function(event) {
  if (event.key === 'Escape') {
    const nav = document.getElementById('nav-links');
    if (nav && nav.classList.contains('show')) {
      nav.classList.remove('show');
    }
  }
});
