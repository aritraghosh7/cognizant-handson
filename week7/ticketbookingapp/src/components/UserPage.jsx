import React from 'react';

const UserPage = ({ onLogout }) => {
  return (
    <div>
      <h2>Welcome, User!</h2>
      <p>You can now book your tickets:</p>

      <ul>
        <li>
          ✈️ Delhi → Mumbai - <button>Book Now</button>
        </li>
        <li>
          ✈️ Bangalore → Kolkata - <button>Book Now</button>
        </li>
        <li>
          ✈️ Hyderabad → Chennai - <button>Book Now</button>
        </li>
      </ul>

      <button onClick={onLogout} style={{ marginTop: '20px' }}>
        Logout
      </button>
    </div>
  );
};

export default UserPage;
