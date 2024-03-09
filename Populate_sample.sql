# Calculate Duration
SELECT tsStart, tsEnd,
    (strftime('%s', tsEnd) - strftime('%s', tsStart)) / 60 as duration_minutes
FROM
    record;
