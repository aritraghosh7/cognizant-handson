import React from 'react';
import styles from './CohortDetails.module.css';

function CohortDetails({ cohort }) {
  const { name, description, status } = cohort;

  const headingStyle = {
    color: status === 'ongoing' ? 'green' : 'blue'
  };

  return (
    <div className={styles.box}>
      <h3 style={headingStyle}>{name}</h3>
      <dl>
        <dt>Description:</dt>
        <dd>{description}</dd>
        <dt>Status:</dt>
        <dd>{status}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;
