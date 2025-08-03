import React from 'react';

const GuestPage = ({ onLogin }) => {
  return (
    <div>
      <h2>Welcome, Guest!</h2>
      <p>You can browse available flights below.</p>

      <ul>
        <li>✈️ Delhi → Mumbai - 10:00 AM</li>
        <li>✈️ Bangalore → Kolkata - 2:30 PM</li>
        <li>✈️ Hyderabad → Chennai - 6:15 PM</li>
      </ul>

      <button onClick={onLogin}>Login to Book</button>
    </div>
  );
};

export default GuestPage;
