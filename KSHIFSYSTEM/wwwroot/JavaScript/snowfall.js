document.addEventListener("DOMContentLoaded", function () {
    const snowfallContainer = document.querySelector(".snowfall");

    // Function to create a snowflake
    function createSnowflake() {
        const snowflake = document.createElement("div");
        snowflake.className = "snowflake";
        snowfallContainer.appendChild(snowflake);

        const size = Math.random() * 3 + 2; // Random size between 2 and 5 pixels
        snowflake.style.width = `${size}px`;
        snowflake.style.height = `${size}px`;

        const xPos = Math.random() * window.innerWidth;
        snowflake.style.left = `${xPos}px`;

        const animationDuration = Math.random() * 5 + 5; // Random duration between 5 and 10 seconds
        snowflake.style.animation = `fall ${animationDuration}s linear infinite`;

        // Remove the snowflake from the DOM after it falls off the screen
        snowflake.addEventListener("animationiteration", function () {
            snowflake.remove();
        });
    }

    // Generate snowflakes at regular intervals
    setInterval(createSnowflake, 500);
});